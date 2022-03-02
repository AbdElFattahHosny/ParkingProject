using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutoCare.Models
{
    public class ApplicationUser : IdentityUser
    {

        [Required]

        public string FirstName { get; set; }
        [Required]

        public string LastName { get; set; }
            
        [Required]
        public string Address { get; set; }
        
        
        public bool IsActive { get; set; }

        public string CreatedBy { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime ModifiedOn { get; set; }


    }
}
