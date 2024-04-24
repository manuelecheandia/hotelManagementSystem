using Hotel.Repo;
using Hotel.Model.DTO;
using Hotel_HotelAuberge.Model;

namespace Hotel.Service
{
    public class GuestService
    {
        private readonly GuestRepo repo;

        public GuestService()
        {
            repo = new GuestRepo();
        }

        public GuestDTO FindGuestByEmail(string email)
        {
            Guest guest = repo.GetGuest(email);

            if (guest != null)
            {
                GuestDTO foundGuest = new GuestDTO
                {
                    Id = guest.Id,
                    FirstName = guest.FirstName,
                    MiddleName = guest.MiddleName,
                    LastName = guest.LastName,
                    DateOfBirth = (DateTime)guest.DateOfBirth
                };

                return foundGuest;
            }
            else
            {
                return null;
            }
        }

        public bool CreateGuest(GuestDTO guestDTO)
        {
            if (IsGuestAboveAge(guestDTO.DateOfBirth))
            {
                Guest guestEntity = new Guest
                {
                    FirstName = guestDTO.FirstName,
                    MiddleName = guestDTO.MiddleName,
                    LastName = guestDTO.LastName,
                    DateOfBirth = guestDTO.DateOfBirth,
                    StreetAddress = guestDTO.StreetAddress,
                    Municipality = guestDTO.Municipality,
                    PostalCode = guestDTO.PostalCode,
                    PrimaryPhoneNumber = guestDTO.PrimaryPhoneNumber,
                    SecondaryPhoneNumber = guestDTO.SecondaryPhoneNumber,
                    EmailAddress = guestDTO.EmailAddress,
                    CountryId = guestDTO.CountryId,
                    ProvinceId = guestDTO.ProvinceId
                };

                return repo.CreateGuest(guestEntity);
            }

            return false;
        }

        #region Private Methods

        private bool IsGuestAboveAge(DateTime dateOfBirth)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - dateOfBirth.Year;

            if (dateOfBirth.Date > today.AddYears(-age)) age--;
                return age >= 18;
        }

        #endregion
    }
}
