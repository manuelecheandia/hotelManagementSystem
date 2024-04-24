using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_HotelAuberge.Model
{
    public class ValidationError
    {
        public string Message { get; set; }

        public ValidationError(string msg)
        {
            Message = msg;
        }
    }
}
