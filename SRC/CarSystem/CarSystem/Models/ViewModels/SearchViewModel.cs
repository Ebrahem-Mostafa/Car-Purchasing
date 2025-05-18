using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CarSystem.Models.ViewModels
{
	public class SearchViewModel
	{

		
		[Range(100000, long.MaxValue, ErrorMessage = "Invalid Input")]
		[RegularExpression(@"^[0-9]+$", ErrorMessage = "Invalid Input")]
		[Display(Name = "Price")]
		public long? Price { get; set; }

		[RegularExpression(@"^(19\d{2}|20\d{2})$", ErrorMessage = "Invalid Input")]
		[Range(1900, 2025, ErrorMessage = "Invalid Input")]
		[Display(Name = "Manufacturing Year")]
		public int? ManufacturingYear { get; set; }

		[DisplayName("Bulding Number")]
		[RegularExpression(@"^[1-9]\d{0,3}$", ErrorMessage = "Invalid Input")]
		public int? BuldingNumber { get; set; }


		[MinLength(3, ErrorMessage = "Invalid Input")]
		[MaxLength(30, ErrorMessage = "Invalid Input")]
		[RegularExpression(@"^[a-zA-Z][a-zA-Z0-9\s]*$", ErrorMessage = "Invalid Input")]
		[Display(Name = "Car Name")]
		public String? CarName { get; set; }

		
		

		
		[StringLength(20, MinimumLength = 3, ErrorMessage = "Invalid Input")]
		[RegularExpression(@"^[a-zA-Z][a-zA-Z ]*[a-zA-Z]$", ErrorMessage = "Invalid Input")]
		public String? Street { get; set; }

		
		[StringLength(20, MinimumLength = 3, ErrorMessage = "Invalid Input")]
		[RegularExpression(@"^[a-zA-Z][a-zA-Z ]*[a-zA-Z]$", ErrorMessage = "Invalid Input")]
		public String? Area { get; set; }

		[StringLength(20, MinimumLength = 3, ErrorMessage = "Invalid Input")]
		[RegularExpression(@"^[a-zA-Z][a-zA-Z ]*[a-zA-Z]$", ErrorMessage = "Invalid Input")]
		public String? City { get; set; }

	
		[StringLength(20, MinimumLength = 3, ErrorMessage = "Invalid Input")]
		[RegularExpression(@"^[a-zA-Z][a-zA-Z ]*[a-zA-Z]$", ErrorMessage = "Invalid Input")]
		public String? Governorate { get; set; }








	}
}
