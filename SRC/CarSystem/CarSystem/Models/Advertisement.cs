using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using CarSystem.DataAnnotation;

namespace CarSystem.Models
{
    public class Advertisement
    {
        public int Id { get; set; }
        public string CreatorId { get; set; }

        public string ? ReserverId { get; set; }

        [Required(ErrorMessage = "Input is not valid")]
        [RegularExpression(@"^[a-zA-Z][a-zA-Z0-9\s]{2,29}$", ErrorMessage = "Input is not valid")]
        [Display(Name = "Car Name")]
        public String CarName { get; set; }


		[Required(ErrorMessage = "Invalid Input")]
		[RegularExpression(@"^(19[0-9]{2}|20[0-9]{2})$", ErrorMessage = "Invalid Input")]
		[Range(1900, 2025, ErrorMessage = "Invalid Input")]
		[Display(Name = "Manufacturing Year")]
		public int? ManufacturingYear { get; set; }


		[Required(ErrorMessage = "Invalid Input")]
		[Range(100_000, 2147483647, ErrorMessage = "Invalid Input")]
		[Display(Name = "Price")]
		public int  Price { get; set; }

		[Required(ErrorMessage = "Invalid Input")]
		[RegularExpression(@"^201\d{9}$", ErrorMessage = "Invalid Input")]
		[Display(Name = "Contact Number")]
		public String PhoneNumber { get; set; }






        [Required(ErrorMessage = "Invalid Input")]
        [DataType(DataType.Date)]
        [Display(Name = "License Expiration Date")]
        [DateRange(3, ErrorMessage = "Date must be between current date and 3 years from now")]
        public DateTime LicenceExpirationDate { get; set; }
        

        [DisplayName("Bulding Number")]
        [Required(ErrorMessage = "Invalid Input")]
        [RegularExpression(@"^[1-9]\d{0,3}$", ErrorMessage = "Invalid Input")]
        public int? BuldingNumber { get; set; }

        [Required(ErrorMessage = "Invalid Input")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Invalid Input")]
        [RegularExpression(@"^[a-zA-Z][a-zA-Z ]*[a-zA-Z]$", ErrorMessage = "Invalid Input")]
        public String Street { get; set; }

        [Required(ErrorMessage = "Invalid Input")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Invalid Input")]
        [RegularExpression(@"^[a-zA-Z][a-zA-Z ]*[a-zA-Z]$", ErrorMessage = "Invalid Input")]
        public String Area { get; set; }

        [Required(ErrorMessage = "Invalid Input")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Invalid Input")]
        [RegularExpression(@"^[a-zA-Z][a-zA-Z ]*[a-zA-Z]$", ErrorMessage = "Invalid Input")]
        public String City { get; set; }

        [Required(ErrorMessage = "Invalid Input")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Invalid Input")]
        [RegularExpression(@"^[a-zA-Z][a-zA-Z ]*[a-zA-Z]$", ErrorMessage = "Invalid Input")]
        public String Governorate { get; set; }
		public string Image { get; set; }


	}
}
