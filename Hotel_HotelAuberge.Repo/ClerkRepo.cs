using DAL;
using Hotel_HotelAuberge.Types;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Repo
{
    public class ClerkRepo
    {
        private readonly DataAccess da;

        public ClerkRepo ()
        {
            da = new DataAccess ();
        }

        public int ValidateClerkCredentials(string username, string password)
        {

            string cmdText = "spGetClerkCredentials";


            List<Parm> parms = new List<Parm>
            {
                new Parm("@Username", SqlDbType.NVarChar, username, 50, ParameterDirection.Input)
            };

 
            DataTable result = da.Execute(cmdText, parms);

            //  given username was found
            if (result.Rows.Count > 0)
            {
                var row = result.Rows[0];
                var storedPassword = row["Password"].ToString();

                // Compare the entered password with the stored password
                if (password.ToString() == storedPassword)
                {
                    // If the passwords match, return the clerk's ID
                    return Convert.ToInt32(row["Id"]);
                }
            }
            return 0;
        }
    }

    public class ClerkSession
    {
        public static int ClerkId { get; set; }

        public static void Login(int clerkId)
        {
            
            ClerkId = clerkId;
        }

        public static int GetCurrentClerkId()
        {
            
            if (ClerkId == 0)
            {
                throw new Exception("No clerk is currently logged in.");
            }

            return ClerkId;
        }

    }
}
