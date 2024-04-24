using Hotel.Model;
using Hotel.Model.DTO;
using Hotel.Repo;
using Hotel_HotelAuberge.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Service
{
    public class RoomService
    {
        private readonly RoomRepo repo;

        public RoomService()
        {
            repo = new RoomRepo();
        }

        public List<RoomsListDTO> GetAll()
        {
            return repo.GetAll();
        }


        public (List<AvailableRoomsDTO>, List<ValidationError>) GetAvailableRooms(AvailableRoomsInputDTO input)
        {

            List<ValidationError> errors = Validate(input);
            if (errors.Count == 0)
            {
                return (repo.GetAvailableRooms(input), null);
            }
            else
            {
                return (null, errors);
            }
        }



        private List<ValidationError> Validate(AvailableRoomsInputDTO input)
        {

            List<ValidationResult> results = new List<ValidationResult>();
            ValidationContext context = new ValidationContext(input);
            Validator.TryValidateObject(input, context, results, true);

            List<ValidationError> errors = new List<ValidationError>();

            foreach (ValidationResult e in results)
            {
                errors.Add(new ValidationError(e.ErrorMessage));
            }


            // Check if the check-in date is not in the past
            if (input.CheckInDate.Date < DateTime.Now.Date)
            {
                errors.Add(new ValidationError("Reservations may not be created for dates that have already occurred."));
            }

            return errors;
        }
    }
}
