using Hotel_HotelAuberge.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Model.DTO
{
    public class ReservationSummaryDTO
    {
        public int Id { get; set; }
        public int RoomNumber { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }
        public string? ConfirmationNumber { get; set; }

        [DataType(DataType.Date)]
        public DateTime? CheckInDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime? CheckOutDate { get; set; }
    }
}
