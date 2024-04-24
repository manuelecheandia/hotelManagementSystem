
using DAL;
using Hotel.Model;
using Hotel.Model.DTO;
using Hotel_HotelAuberge.Model;
using Hotel_HotelAuberge.Types;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Repo
{
    public class ReservationRepo
    {
        private readonly DataAccess da;

        public ReservationRepo()
        {
            da = new DataAccess();
        }

        public ReservationDetailsDTO GetReservation(int id)
        {
            string commandText = "spGetReservationDetails";

            List<Parm> parameters = new List<Parm>
            {
                new Parm("@ConfirmationNumber", SqlDbType.Int, id)
            };

            DataTable result = da.Execute(commandText, parameters, CommandType.StoredProcedure);

            if (result.Rows.Count > 0)
            {
                // get reservation, guest, and room details
                Reservation reservation = new Reservation
                {
                    Id = Convert.ToInt32(result.Rows[0]["ReservationId"]),
                    GuestId = Convert.ToInt32(result.Rows[0]["GuestId"]),
                    CheckInDate = Convert.ToDateTime(result.Rows[0]["CheckInDate"]),
                    CheckOutDate = Convert.ToDateTime(result.Rows[0]["CheckOutDate"]),
                    NumAdults = Convert.ToInt32(result.Rows[0]["NumAdults"]),
                    NumChildren = Convert.ToInt32(result.Rows[0]["NumChildren"]),
                    RoomId = Convert.ToInt32(result.Rows[0]["RoomId"]),
                    ConfirmationNumber = result.Rows[0]["ConfirmationNumber"]?.ToString(),
                    DailyRate = Convert.ToDecimal(result.Rows[0]["DailyRate"]),
                    PerAdultFee = Convert.ToDecimal(result.Rows[0]["PerAdultFee"]),
                    PerChildFee = Convert.ToDecimal(result.Rows[0]["PerChildFee"]),
                    Total = Convert.ToDecimal(result.Rows[0]["Total"])
                };

                GuestDTO guestInfo = new GuestDTO
                {
                    Id = Convert.ToInt32(result.Rows[0]["GuestId"]),
                    FirstName = result.Rows[0]["FirstName"].ToString(),
                    MiddleName = result.Rows[0]["MiddleName"].ToString(),
                    LastName = result.Rows[0]["LastName"].ToString(),
                    StreetAddress = result.Rows[0]["StreetAddress"].ToString(),
                    Municipality = result.Rows[0]["Municipality"].ToString(),
                    ProvinceId = Convert.ToInt32(result.Rows[0]["ProvinceId"]),
                    CountryId = Convert.ToInt32(result.Rows[0]["CountryId"]),
                    PostalCode = result.Rows[0]["PostalCode"].ToString(),
                    PrimaryPhoneNumber = result.Rows[0]["PrimaryPhoneNumber"].ToString(),
                    SecondaryPhoneNumber = result.Rows[0]["SecondaryPhoneNumber"].ToString(),
                    EmailAddress = result.Rows[0]["EmailAddress"].ToString(),
                    DateOfBirth = Convert.ToDateTime(result.Rows[0]["DateOfBirth"])
                };

                int roomNumber = Convert.ToInt32(result.Rows[0]["RoomNumber"]);
                string bedConfiguration = result.Rows[0]["BedConfiguration"].ToString(); 
                string roomTypeDesc = result.Rows[0]["RoomTypeDesc"].ToString();

                ReservationDetailsDTO reservationDetails = new ReservationDetailsDTO
                {
                    Reservation = reservation,
                    GuestInfo = guestInfo,
                    RoomNumber = roomNumber,
                    BedConfiguration = bedConfiguration,
                    RoomTypeDesc = roomTypeDesc
                };

                return reservationDetails;
            }

            return null;
        }

        public List<ReservationSummaryDTO> GetReservations(ReservationSearchInputDTO input)
        {
            string commandText = "spSearchAvailableRooms";

            List<Parm> parameters = new List<Parm>
            {
                new Parm("@CheckInDate", SqlDbType.DateTime, input.CheckInDate),
                new Parm("@CheckOutDate", SqlDbType.DateTime, input.CheckOutDate)
            };

            DataTable result = da.Execute(commandText, parameters, CommandType.StoredProcedure);

            List<ReservationSummaryDTO> reservations = new List<ReservationSummaryDTO>();

            foreach (DataRow row in result.Rows)
            {
                ReservationSummaryDTO reservationSummary = new ReservationSummaryDTO
                {
                    RoomNumber = Convert.ToInt32(row["RoomNumber"]),
                    FirstName = row["FirstName"].ToString(),
                    LastName = row["LastName"].ToString()
                };

                reservations.Add(reservationSummary);
            }

            return reservations;
        }

        public string CreateReservation(ReservationCreateDTO reservationDTO)
        {
            string commandText = "spCreateReservation";

            int clerkId = ClerkSession.GetCurrentClerkId();

            List<Parm> parameters = new List<Parm>
            {
                new Parm("@GuestId", SqlDbType.Int, reservationDTO.GuestId),
                new Parm("@RoomId", SqlDbType.Int, reservationDTO.RoomId),
                new Parm("@ClerkId", SqlDbType.Int, clerkId),
                new Parm("@CheckInDate", SqlDbType.DateTime, reservationDTO.CheckInDate),
                new Parm("@CheckOutDate", SqlDbType.DateTime, reservationDTO.CheckOutDate),
                new Parm("@NumberOfAdults", SqlDbType.Int, reservationDTO.NumAdults),
                new Parm("@NumberOfChildren", SqlDbType.Int, reservationDTO.NumChildren),
                new Parm("@PerAdultFee", SqlDbType.Money, reservationDTO.PerAdultFee),
                new Parm("@PerChildFee", SqlDbType.Money, reservationDTO.PerChildFee),
                new Parm("@RoomDailyRate", SqlDbType.Money, reservationDTO.DailyRate),
                new Parm("@ConfirmationNumber", SqlDbType.NVarChar, reservationDTO.ConfirmationNumber)
            };

            string confirmationNumber = da.ExecuteResStoredProcedure(commandText, parameters, CommandType.StoredProcedure);

            return confirmationNumber;
        }

        public string GetClerkInitials(int clerkId)
        {
            string cmdText = "spGetClerkName";

            List<Parm> parms = new List<Parm>
            {
                new Parm("@ClerkId", SqlDbType.Int, clerkId, 0, ParameterDirection.Input)
            };

            DataTable result = da.Execute(cmdText, parms);

            if (result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];
                string firstName = row["FirstName"].ToString();
                string lastName = row["LastName"].ToString();

                return firstName[0].ToString() + lastName[0].ToString();
            }
            return "";

        }

        public Guest GetGuestById(int guestId)
        {
            string cmdText = "spGetGuestById";

            List<Parm> parms = new List<Parm>
            {
                new Parm("@GuestId", SqlDbType.Int, guestId)
            };

            DataTable result = da.Execute(cmdText, parms);

            if (result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];

                Guest guest = new Guest
                {
                    Id = Convert.ToInt32(row["Id"]),
                    FirstName = row["FirstName"].ToString(),
                    LastName = row["LastName"].ToString()
                };

                return guest;
            }

            return null;
        }

        public Reservation GetReservationByConfirmationNumber(string confirmationNumber)
        {

            string cmdText = "spGetReservationByConfirmationNumber";


            List<Parm> parms = new List<Parm>
            {
                new Parm("@ConfirmationNumber", SqlDbType.NVarChar, confirmationNumber)
            };

            DataTable result = da.Execute(cmdText, parms);


            if (result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];

                Reservation reservation = new Reservation
                {
                    ConfirmationNumber = row["ConfirmationNumber"].ToString()
                };

                return reservation;
            }

            return null;
        }


        public decimal GetRoomDailyRate(int roomId)
        {
            string commandText = "SELECT DailyRate FROM Room WHERE Id = @RoomId";

            List<Parm> parameters = new List<Parm>
            {
                new Parm("@RoomId", SqlDbType.Int, roomId)
            };

            DataTable result = da.Execute(commandText, parameters, CommandType.Text);

            if (result.Rows.Count > 0)
            {
                decimal dailyRate = Convert.ToDecimal(result.Rows[0]["DailyRate"]);
                return dailyRate;
            }

            return 0;
        }

        public GuestFeesDTO GetGuestFeeByType(string type)
        {
            string commandText = "spGetGuestFee";

            List<Parm> parameters = new List<Parm>
            {
                new Parm("@Type", SqlDbType.NVarChar, type)
            };

            DataTable result = da.Execute(commandText, parameters);

            if (result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];

                GuestFeesDTO guestFee = new GuestFeesDTO
                {
                    Type = row["Type"].ToString(),
                    Rate = (decimal)row["Rate"]
                };

                return guestFee;
            }

            return null; 
        }

        public List<ReservationSummaryDTO> GetReservationSummaries(ReservationSearchInputDTO input)
        {
            List<ReservationSummaryDTO> reservationSummaries = new List<ReservationSummaryDTO>();

            string sortProperty = "CheckInDate";
            string sortOrder = "ASC";

            List<Parm> parameters = new List<Parm>
              {
                  new Parm("@SortProperty", SqlDbType.NVarChar, sortProperty),
                  new Parm("@SortOrder", SqlDbType.NVarChar, sortOrder)
              };

            DataTable dataTable = da.Execute("spGetReservationsSummary", parameters, CommandType.StoredProcedure);

            foreach (DataRow row in dataTable.Rows)
            {
                ReservationSummaryDTO summary = new ReservationSummaryDTO
                {
                    Id = Convert.ToInt32(row["Id"]),
                    RoomNumber = Convert.ToInt32(row["RoomNumber"]),
                    FirstName = row["GuestFirstName"].ToString(),
                    LastName = row["GuestLastName"].ToString(),
                    ConfirmationNumber = row["ConfirmationNumber"].ToString(),
                    CheckInDate = Convert.ToDateTime(row["CheckInDate"]),
                    CheckOutDate = Convert.ToDateTime(row["CheckOutDate"]),
                };
                reservationSummaries.Add(summary);
            }

            return reservationSummaries;
        }
    }
    
}

