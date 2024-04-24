using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Model.DTO
{
    public class CountryListDTO
    {
        public int Id { get; set; }

        public string? ISOCode { get; set; }
        public string? Name { get; set; }
    }
}
