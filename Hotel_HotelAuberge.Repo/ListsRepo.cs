using DAL;
using Hotel.Model.DTO;
using System.Collections.Generic;

namespace Hotel.Repo
{
    public class ListsRepo
    {
        private readonly DataAccess da;

        public ListsRepo()
        {
            da = new DataAccess();
        }

        public List<ProvinceListDTO> GetProvinces()
        {
            List<ProvinceListDTO> provinces = new List<ProvinceListDTO>();

            string cmdText = "spGetProvince";
            var dataTable = da.Execute(cmdText);

            foreach (System.Data.DataRow row in dataTable.Rows)
            {
                provinces.Add(new ProvinceListDTO
                {
                    Id = (int)row["Id"],
                    Name = row["ProvinceName"].ToString(),
                    Abbr = row["Abbr"].ToString()
                });
            }

            return provinces;
        }

        public List<CountryListDTO> GetCountries()
        {
            List<CountryListDTO> countries = new List<CountryListDTO>();

            string cmdText = "spGetCountry";
            var dataTable = da.Execute(cmdText);

            foreach (System.Data.DataRow row in dataTable.Rows)
            {
                countries.Add(new CountryListDTO
                {
                    Id = (int)row["Id"],
                    Name = row["CountryName"].ToString()
                });
            }

            return countries;
        }

        public GuestFeesDTO GetPerAdultAndChildFees()
        {
            string cmdText = "spGetPerAdultAndChildFees";
            var result = da.ExecuteResStoredProcedure(cmdText);

            GuestFeesDTO guestFees = new GuestFeesDTO();


            return guestFees;
        }
    }
}
