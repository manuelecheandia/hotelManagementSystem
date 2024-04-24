using Hotel.Repo;
using Hotel.Model.DTO;

namespace Hotel.Service
{
    public class ListsService
    {
        private readonly ListsRepo repo;

        public ListsService()
        {
            repo = new ListsRepo();
        }

        public List<ProvinceListDTO> GetProvinces()
        {
            return repo.GetProvinces();
        }

        public List<CountryListDTO> GetCountries()
        {
            return repo.GetCountries();
        }

        public GuestFeesDTO GetPerAdultAndChildFees()
        {
            return repo.GetPerAdultAndChildFees();
        }
    }
}