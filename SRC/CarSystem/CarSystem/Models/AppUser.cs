using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace CarSystem.Models
{
    public class AppUser:IdentityUser
    {
        [Required(ErrorMessage = "Invalid Input")]
        [StringLength(8, ErrorMessage = "Invalid Input")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Invalid Input")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Invalid Input")]
        [StringLength(8, ErrorMessage = "Invalid Input")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Invalid Input")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Invalid Input")]
        [StringLength(30, ErrorMessage = "Invalid Input")]
        [RegularExpression(@"^[a-zA-Z0-9\s.,]+$", ErrorMessage = "Invalid Input")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Invalid Input")]
        [Range(18, 120, ErrorMessage = "Invalid Input")]
        [RegularExpression("^[0-9]+$", ErrorMessage = "Invalid Input")]
        public int Age { get; set; }

    }
}
