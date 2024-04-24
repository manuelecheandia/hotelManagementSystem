using Hotel.Repo;
using Hotel.Model.DTO;
using System.Collections.Generic;
using Hotel_HotelAuberge.Model;
using Hotel_HotelAuberge.Types;
using System.Data;

namespace Hotel.Service
{
    public class ReservationService
    {
        private readonly ReservationRepo repo;

        public ReservationService()
        {
            repo = new ReservationRepo();
        }

        public ReservationDetailsDTO GetReservation(int id)
        {
            return repo.GetReservation(id);
        }

        public List<ReservationSummaryDTO> GetReservations(ReservationSearchInputDTO input)
        {
            return repo.GetReservations(input);
        }

        public bool CreateReservation(ReservationCreateDTO reservationDTO)
        {
            // get the first initials of clerk and guest
            string clerkInitials = repo.GetClerkInitials(ClerkSession.GetCurrentClerkId());
            string guestInitials = GetGuestInitials(reservationDTO.GuestId);

            string confirmationNumberString;
            do
            {
                Random random = new Random();
                int randomNumber = random.Next(10000000, 99999999);

                //Confirmation number structure
                confirmationNumberString = clerkInitials + guestInitials + randomNumber.ToString();
            }
            while (!IsConfirmationNumberUnique(confirmationNumberString));

            reservationDTO.ConfirmationNumber = confirmationNumberString;


            decimal roomDailyRate = GetRoomDailyRate(reservationDTO.RoomId);
            reservationDTO.DailyRate = roomDailyRate;

            int numberOfNights = (int)(reservationDTO.CheckOutDate - reservationDTO.CheckInDate).TotalDays;

            decimal totalCost = roomDailyRate * numberOfNights;

            totalCost += CalculateExtraGuestFee(reservationDTO.NumAdults, reservationDTO.NumChildren);

            reservationDTO.CheckInDate = RoundToNextWholeDay(reservationDTO.CheckInDate);
            reservationDTO.CheckOutDate = RoundToNextWholeDay(reservationDTO.CheckOutDate);

            reservationDTO.Total = totalCost;

            string confirmationNumber = repo.CreateReservation(reservationDTO);

            return !string.IsNullOrEmpty(confirmationNumber); 

        }

        public List<ReservationSummaryDTO> GetReservationSummaries(ReservationSearchInputDTO input)
        {
            return repo.GetReservationSummaries(input);
        }


        #region Private Methods


        private string GetGuestInitials(int guestId)
        {
            Guest guest = repo.GetGuestById(guestId); 

            string initials = guest.FirstName[0].ToString() + guest.LastName[0].ToString();
            return initials;
        }

        private bool IsConfirmationNumberUnique(string confirmationNumber)
        {
            Reservation reservation = repo.GetReservationByConfirmationNumber(confirmationNumber); 

            return reservation == null;
        }


        private decimal CalculateExtraGuestFee(int numberOfAdultGuests, int numberOfChildGuests)
        {
            decimal additionalAdultGuestFee = 0;
            decimal additionalChildGuestFee = 0;

            // Gets  adult and child guest fees from DB
            GuestFeesDTO adultGuestFee = repo.GetGuestFeeByType("PerAdultGuestFee");
            GuestFeesDTO childGuestFee = repo.GetGuestFeeByType("PerChildGuestFee");

            if (adultGuestFee != null)
            {
                additionalAdultGuestFee = numberOfAdultGuests > 1 ? (numberOfAdultGuests - 1) * adultGuestFee.Rate : 0;
            }

            if (childGuestFee != null)
            {
                additionalChildGuestFee = numberOfChildGuests * childGuestFee.Rate;
            }

            decimal totalExtraGuestFee = additionalAdultGuestFee + additionalChildGuestFee;
            return totalExtraGuestFee;
        }

        private DateTime RoundToNextWholeDay(DateTime date)
        {
            // Ensures a whole-day increment
            return date.Date.AddDays(1);
        }

        private decimal GetRoomDailyRate(int roomId)
        {
            return repo.GetRoomDailyRate(roomId);
        }

         
        #endregion
    }
}

