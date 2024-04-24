using System;

namespace Hotel.Model.DTO
{
    public class ReservationSearchInputDTO
    {
        public DateTime DateCreated { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; } 
        public int RoomId { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string ConfirmationNumber { get; set; }
    }
}
