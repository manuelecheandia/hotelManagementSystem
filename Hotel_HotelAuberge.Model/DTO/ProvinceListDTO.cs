using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Model.DTO
{
    public class ProvinceListDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Abbr { get; set; }

        public int CountryId { get; set; }
    }
}
