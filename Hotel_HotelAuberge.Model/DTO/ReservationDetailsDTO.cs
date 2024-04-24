using Hotel_HotelAuberge.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Model.DTO
{
    public class ReservationDetailsDTO
    {
        public Reservation Reservation { get; set; }
        public GuestDTO GuestInfo { get; set; }
        public int RoomNumber { get; set; }
        public string BedConfiguration { get; set; }
        public string RoomTypeDesc { get; set; }
    }
}
