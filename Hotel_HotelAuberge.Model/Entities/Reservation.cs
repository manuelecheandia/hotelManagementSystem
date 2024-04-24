using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_HotelAuberge.Model
{
    public class Reservation : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public int GuestId { get; set; }
        public Guest Guest { get; set; }

        [DataType(DataType.Date)]
        public DateTime CheckInDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime CheckOutDate { get; set; }
        public int NumAdults { get; set; }
        public int NumChildren { get; set; }
        public int RoomId { get; set; }
        public string? ConfirmationNumber { get; set; }
        public decimal DailyRate { get; set; }
        public decimal PerAdultFee { get; set; }
        public decimal PerChildFee { get; set; }
        public decimal Total { get; set; }

    }
}
