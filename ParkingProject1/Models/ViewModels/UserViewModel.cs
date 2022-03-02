using System.ComponentModel.DataAnnotations;

namespace ParkingProject1.Models.ViewModels
{
    public class UserViewModel
    {
        [Required]

        public string FirstName { get; set; }
        [Required]

        public string LastName { get; set; }
        [Required]
        [Display(Name = "PhoneNumber")]
        public string password { get; set; }
       
       
        public long PhoneNumber { get; set; }
        [Required]
        public string Address { get; set; }

        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Invalid Email Address")]

        public string Email { get; set; }

    }
}
