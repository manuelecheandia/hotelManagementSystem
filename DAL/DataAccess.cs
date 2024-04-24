using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;
using System.Data;
using Hotel_HotelAuberge.Types;

namespace DAL
{
    public class DataAccess
    {
        #region Fields

        // Connection string for the database
        private readonly string? connectionString;

        #endregion

        #region Constructors

        // Constructor that initializes the connection string from appsettings
        public DataAccess()
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            
            connectionString = builder.Build().GetConnectionString("HotelConnStr");
        }
        #endregion

        #region Public Methods

        // Executes a SQL command and returns the result as a DataTable
        public DataTable Execute(string cmdText, List<Parm>? parms = null,
            CommandType cmdType = CommandType.StoredProcedure)
        {
            DataTable dt = new();
            SqlCommand cmd = CreateCommand(cmdText, parms, cmdType);

            using (cmd.Connection)
            {
                SqlDataAdapter da = new(cmd);

                da.Fill(dt);
            }

            return dt;
        }


        // Executes a SQL command and returns the first column of the first row in the result set
        public object ExecuteScalar(string cmdText, List<Parm>? parms = null, CommandType cmdType = CommandType.StoredProcedure)
        {
            object retVal;
            SqlCommand cmd = CreateCommand(cmdText, parms, cmdType);

            using (cmd.Connection)
            {
                cmd.Connection.Open();
                retVal = cmd.ExecuteScalar();


                UnloadParams(parms, cmd);
            }

            return retVal;
        }

        // Unloads the parameters after executing a SQL command
        private void UnloadParams(List<Parm>? parms, SqlCommand cmd)
        {
            if (parms is null) return;

            for (int i = 0; i < parms.Count; i++)
            {
                parms[i].Value = cmd.Parameters[i].Value;
            }
        }

        // Executes a SQL command and returns the number of rows affected
        public int ExecuteNonQuery(string cmdText, List<Parm>? parms = null, CommandType cmdType = CommandType.StoredProcedure)
        {
            int rowsAffected = 0;
            SqlCommand cmd = CreateCommand(cmdText, parms, cmdType);

            using (cmd.Connection)
            {
                cmd.Connection.Open();
                rowsAffected = cmd.ExecuteNonQuery();
            }

            return rowsAffected;
        }

        public string ExecuteResStoredProcedure(string cmdText, List<Parm>? parms = null, CommandType cmdType = CommandType.StoredProcedure)
        {
            string confirmationNumber = string.Empty;
            SqlCommand cmd = CreateCommand(cmdText, parms, cmdType);

            using (cmd.Connection)
            {
                cmd.Connection.Open();
                confirmationNumber = cmd.ExecuteScalar().ToString();
            }

            return confirmationNumber;
        }


        #endregion

        #region Private Methods

        // Creates a SQL command with the given command text, parameters, and command type
        private SqlCommand CreateCommand(string cmdText, List<Parm>? parms, CommandType cmdType)
        {
            SqlConnection conn = new(connectionString);

            SqlCommand cmd = new(SQLCleaner(cmdText), conn) { CommandType = cmdType };

            if (parms != null)
                foreach (Parm p in parms)
                {
                    cmd.Parameters.Add(new SqlParameter
                    {
                        ParameterName = p.Name,
                        SqlDbType = p.DataType,
                        Size = p.Size,
                        Value = p.Value,
                        Direction = p.Direction,
                    });
                }

            return cmd;
        }

        // Cleans the SQL command text by removing extra spaces and newlines
        private string SQLCleaner(string sql)
        {
            while (sql.Contains("  "))
                sql = sql.Replace("  ", " ");

            return sql.Replace(Environment.NewLine, "");
        }

        #endregion
    }
}