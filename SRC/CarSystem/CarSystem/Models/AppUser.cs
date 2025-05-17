using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace CarSystem.Models
{
    public class AppUser:IdentityUser
    {

		[Required(ErrorMessage = "Invalid Input")]
		[MaxLength(8, ErrorMessage = "Invalid Input")]
		[RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Invalid Input")]
		[Display(Name = "First Name")]
		public string FirstName { get; set; }



		[Required(ErrorMessage = "Invalid Input")]
		[MaxLength(8, ErrorMessage = "Invalid Input")]
		[RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Invalid Input")]
		[Display(Name = "Last Name")]
		public string LastName { get; set; }

		[Required(ErrorMessage = "Invalid Input")]
		[MaxLength(30, ErrorMessage = "Invalid Input")]
		[RegularExpression(@"^[\w\s\-.,!@#$%^&*()=]+$", ErrorMessage = "Invalid Input")]
		[Display(Name = "Address")]
		public string Address { get; set; }

		[Required(ErrorMessage = "Invalid Input")]
		[Range(18, 150, ErrorMessage = "Invalid Input")]
		[RegularExpression(@"^[0-9]+$", ErrorMessage = "Invalid Input")]
		[Display(Name = "Age")]
		public int Age { get; set; }

    }
}
