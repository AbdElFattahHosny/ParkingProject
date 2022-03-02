using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParkingProject.Models
{
    public class Slot : CreationandModifications
    {
     
        public long Number { get; set; }

        public Area Area { get; set; }
        [ForeignKey("Area")]
        [Display(Name = "Area")]
        public long? AreaId { get; set; }

        public ICollection<BusySlots> BusySlots { get; set; }

        public ICollection<Reservations> Reservations { get; set; }

    }
}
