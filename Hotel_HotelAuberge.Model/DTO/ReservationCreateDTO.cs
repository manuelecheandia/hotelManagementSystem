using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Model.DTO
{
    public class ReservationCreateDTO
    {
        public int Id { get; set; }
        public int GuestId { get; set; }
        public int RoomId { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public int NumAdults { get; set; }
        public int NumChildren { get; set; }
        public string ConfirmationNumber { get; set; }
        public decimal DailyRate { get; set; }
        public decimal PerAdultFee { get; set; }
        public decimal PerChildFee { get; set; }
        public decimal Total { get; set; }

    }


}
