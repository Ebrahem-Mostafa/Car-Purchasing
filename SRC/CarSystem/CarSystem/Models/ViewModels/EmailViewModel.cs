using System.ComponentModel.DataAnnotations;

namespace CarSystem.Models.ViewModels
{
    public class EmailViewModel
    {

        [Required]
        [EmailAddress(ErrorMessage = "Invalid Input")]
        [RegularExpression(@"^[a-zA-Z][a-zA-Z0-9._-]*@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Invalid Input")]
        public string? Email { get; set; }
    }
}
