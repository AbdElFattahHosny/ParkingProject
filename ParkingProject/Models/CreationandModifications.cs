using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingProject.Models
{
    public abstract class CreationandModifications
    {
        [Key]
        public long Id { get; set; }

        public bool IsActive { get; set; }

        public long? CreatedBy { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime CreatedOn { get; set; }
        public long? ModifiedBy { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime ModifiedOn { get; set; }

    }
}
