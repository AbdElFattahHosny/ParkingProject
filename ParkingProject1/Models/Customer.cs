using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParkingProject11.Models
{
    public class Customer : CreationandModifications
    {
        
        [Required(ErrorMessage = "First Name is Required")]
        [Column(TypeName = "nvarchar(50)")]
        [MaxLength(50, ErrorMessage = "Must Be Less Than 50 characters")]
        [Display(Name = "First Name")]

        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is Required")]
        [Column(TypeName = "nvarchar(50)")]
        [MaxLength(50, ErrorMessage = "Must Be Less Than 50 characters")]
        [Display(Name = "Last Name")]

        public string LastName { get; set; }

        [Column(TypeName = "nvarchar(50)")]

        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Mobile is Required")]
        [Column(TypeName = "nvarchar(20)")]
        public string Mobile { get; set; }

        [Column(TypeName = "nvarchar(MAX)")]
        public string NationalIDPhoto { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        [Column(TypeName = "nvarchar(20)")]
        [DataType(DataType.Password)]
        [MaxLength(20, ErrorMessage = "Must be less than or equals 20 chars")]
        [MinLength(5, ErrorMessage = "Must be more than 5 chars")]
        public string Password { get; set; }

   

        public ICollection<FeedBacks> FeedBacks { get; set; }
        public ICollection<Reservations> Reservations { get; set; }

  
    }
}
