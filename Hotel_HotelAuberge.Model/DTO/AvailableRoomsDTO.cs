using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Model.DTO
{
    public class AvailableRoomsDTO
    {
        public int RoomId { get; set; }
        public int RoomNumber { get; set; }
        public string RoomName { get; set; }
        public string BedConfiguration { get; set; }
        public int MaxOccupancy { get; set; }
        public decimal DailyRate { get; set; }
        public string RoomType { get; set; }
    }

}
