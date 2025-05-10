using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace CarSystem.Models
{
    public class AdvertisementtViewModel
    {

        
        public int ReserverId { get; set; }
        public int CreatorId { get; set; }
       
        public int Id { get; set; }
		[Required(ErrorMessage = "Invalid Input")]
		[StringLength(30, MinimumLength = 3, ErrorMessage = "Invalid Input")]
		[RegularExpression(@"^[a-zA-Z][a-zA-Z0-9\s]*$", ErrorMessage = "Invalid Input")]
		[DisplayName("Car Name")]
		public String CarName { get; set; }

		[DisplayName("Manufacturing Year")]
		[Required(ErrorMessage = "Invalid Input")]
		[RegularExpression(@"^(19[0-9]{2}|20[0-9]{2})$", ErrorMessage = "Invalid Input")]
		[Range(1900, 2023, ErrorMessage = "Invalid Input")]
		public int? ManufacturingYear { get; set; }

		[DisplayName("Price")]
		[Required(ErrorMessage = "Invalid Input")]
		[Range(100000, long.MaxValue, ErrorMessage = "Invalid Input")]
		[RegularExpression(@"^[1-9]\d*$", ErrorMessage = "Invalid Input")]
		public int Price { get; set; }


		[DisplayName("Phone Number")]
		[Required(ErrorMessage = "Invalid Input")]
		[StringLength(12, MinimumLength = 12, ErrorMessage = "Invalid Input")]
		[RegularExpression(@"^20[1-9]\d{8}$", ErrorMessage = "Invalid Input")]
		public String PhoneNumber { get; set; }

        
        [DisplayName("Licence Expiration Date")]
        public DateTime LicenceExpirationDate { get; set; }
        
        public IFormFile? Image { get; set; }
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
	}
}
