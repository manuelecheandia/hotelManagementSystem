using DAL;
using Hotel.Model.DTO;
using Hotel_HotelAuberge.Model;
using Hotel_HotelAuberge.Types;
using System;
using System.Collections.Generic;
using System.Data;

namespace Hotel.Repo
{
    public class GuestRepo
    {
        private readonly DataAccess da;

        public GuestRepo()
        {
            da = new DataAccess(); 
        }

        public Guest GetGuest(string email)
        {
            Guest guest = null;
            try
            {
                List<Parm> parms = new List<Parm>
                {
                    new Parm("@EmailAddress", SqlDbType.NVarChar, email, 100, ParameterDirection.Input)
                };

                DataTable dt = da.Execute("spGetGuestByEmail", parms);

                if (dt != null && dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0]; 

                    guest = new Guest
                    {
                        Id = Convert.ToInt32(row["Id"]),
                        FirstName = Convert.ToString(row["FirstName"]),
                        LastName = Convert.ToString(row["LastName"]),
                        MiddleName = Convert.ToString(row["MiddleName"]),
                        DateOfBirth = (DateTime?)row["DateOfBirth"]
                    };
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching guest: {ex.Message}");
            }

            return guest;
        }

        public bool CreateGuest(Guest guest)
        {
            bool success = false;
            try
            {
                List<Parm> parms = new List<Parm>
                {
                    new Parm("@Id", SqlDbType.Int, guest.Id, 0, ParameterDirection.Output),
                    new Parm("@FirstName", SqlDbType.NVarChar, guest.FirstName, 50, ParameterDirection.Input),
                    new Parm("@LastName", SqlDbType.NVarChar, guest.LastName, 50, ParameterDirection.Input),
                    new Parm("@MiddleName", SqlDbType.NVarChar, guest.MiddleName, 50, ParameterDirection.Input),
                    new Parm("@StreetAddress", SqlDbType.NVarChar, guest.StreetAddress, 50, ParameterDirection.Input),
                    new Parm("@Municipality", SqlDbType.NVarChar, guest.Municipality, 50, ParameterDirection.Input),
                    new Parm("@PostalCode", SqlDbType.NVarChar, guest.PostalCode, 50, ParameterDirection.Input),
                    new Parm("@PrimaryPhoneNumber", SqlDbType.NVarChar, guest.PrimaryPhoneNumber, 50, ParameterDirection.Input),
                    new Parm("@SecondaryPhoneNumber", SqlDbType.NVarChar, guest.SecondaryPhoneNumber, 50, ParameterDirection.Input),
                    new Parm("@EmailAddress", SqlDbType.NVarChar, guest.EmailAddress, 50, ParameterDirection.Input),
                    new Parm("@DateOfBirth", SqlDbType.DateTime2, guest.DateOfBirth, 50, ParameterDirection.Input),
                    new Parm("@CountryId", SqlDbType.Int, guest.CountryId, 50, ParameterDirection.Input),
                    new Parm("@ProvinceId", SqlDbType.Int, guest.ProvinceId, 50, ParameterDirection.Input)
                    
                };


                int rowsAffected = da.ExecuteNonQuery("spCreateGuest", parms);

                if (rowsAffected > 0)
                {
                    // If successful, retrieve the new Id
                    guest.Id = (int?)parms.FirstOrDefault(p => p.Name == "@Id")!.Value ?? 0;
                }
                else
                {
                    throw new DataException("There was an issue adding the record to the database.");
                }

                success = rowsAffected > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating guest: {ex.Message}");
            }

            return success;
        }
    }
}
