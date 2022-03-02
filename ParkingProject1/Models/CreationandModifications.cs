using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingProject11.Models
{
    public abstract class CreationandModifications
    {
        [Key]
        public long Id { get; set; }

        public bool IsActive { get; set; }

        public string CreatedBy { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime ModifiedOn { get; set; }

    }
}
