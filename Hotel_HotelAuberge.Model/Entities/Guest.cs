using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_HotelAuberge.Model
{
    public class Guest : BaseEntity
    {
        
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="First Name is required")]
        [StringLength(50, ErrorMessage = "First Name cannot exceed 50 characters.")]
        public string? FirstName { get; set; }

        [StringLength(50, ErrorMessage = "MiddleName cannot exceed 50 characters.")]
        public string? MiddleName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(50, ErrorMessage = "Last Name cannot exceed 50 characters.")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Street Address is required")]
        [StringLength(255, ErrorMessage = "The Street Address cannot exceed 255 characters.")]
        public string? StreetAddress { get; set; }

        [Required(ErrorMessage = "Municipality is required")]
        [StringLength(50, ErrorMessage = "Municipality cannot exceed 50 characters.")]
        public string? Municipality { get; set; }

        public int? ProvinceId { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Country is required.")]
        public int CountryId { get; set; }


        [StringLength(10, ErrorMessage = "PostalCode cannot exceed 10 characters.")]
        public string? PostalCode { get; set; }

        [Required(ErrorMessage = "Primary Phone Number is required")]
        [StringLength(12, ErrorMessage = "Primary Phone Number cannot exceed 12 characters.")]
        public string? PrimaryPhoneNumber { get; set; }

        [StringLength(12, ErrorMessage = "Secondary Phone Number cannot exceed 12 characters.")]
        public string? SecondaryPhoneNumber { get; set;}

        [Required(ErrorMessage = "Email Address is required")]
        [EmailAddress]
        [StringLength(100, ErrorMessage = "Email Address cannot exceed 100 characters.")]
        public string? EmailAddress { get; set; }

        [Required(ErrorMessage = "Date of Birth is required")]
        public DateTime? DateOfBirth { get; set; }

    }
}
