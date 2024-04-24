using Hotel.Model.DTO;
using Hotel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Hotel_HotelAuberge.Types;
using System.Data;

namespace Hotel.Repo
{
    public class RoomRepo
    {
        private readonly DataAccess da;

        public RoomRepo()
        {
            da = new DataAccess();
        }

        public List<RoomsListDTO> GetAll()
        {
            List<Parm> parameters = new List<Parm>();
            DataTable dataTable = da.Execute("spGetRooms", parameters, CommandType.StoredProcedure);

            List<RoomsListDTO> rooms = new List<RoomsListDTO>();

            foreach (DataRow row in dataTable.Rows)
            {
                RoomsListDTO room = new RoomsListDTO
                {
                    Id = Convert.ToInt32(row["Id"]),
                    RoomName = row["RoomName"].ToString(),
                    RoomNumber = Convert.ToInt32(row["RoomNumber"])

                };

                rooms.Add(room);
            }

            return rooms;
        }

        public List<AvailableRoomsDTO> GetAvailableRooms(AvailableRoomsInputDTO input)
        {
            List<AvailableRoomsDTO> availableRooms = new List<AvailableRoomsDTO>();

            List<Parm> parameters = new List<Parm>
            {
                new Parm("@CheckInDate", SqlDbType.DateTime, input.CheckInDate),
                new Parm("@CheckOutDate", SqlDbType.DateTime, input.CheckOutDate)
            };

            DataTable dataTable = da.Execute("spSearchAvailableRooms", parameters, CommandType.StoredProcedure);

            foreach (DataRow row in dataTable.Rows)
            {
                AvailableRoomsDTO room = new AvailableRoomsDTO
                {
                    RoomId = Convert.ToInt32(row["Id"]),
                    RoomName = row["RoomName"].ToString(),
                    RoomNumber = Convert.ToInt32(row["RoomNumber"]),
                    BedConfiguration = row["BedConfigurationDesc"].ToString(),
                    DailyRate = Convert.ToDecimal(row["DailyRate"]),
                    MaxOccupancy = Convert.ToInt32(row["MaxOccupancy"]),
                    RoomType = row["RoomType"].ToString()
                };

                availableRooms.Add(room);
            }

            return availableRooms;
        }

    }
}
