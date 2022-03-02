using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParkingProject.Models
{
    public class BusySlots : CreationandModifications
    {
        public Area Area { get; set; }
        [ForeignKey("Area")]
        [Display(Name = "Area")]
        public long? AreaId { get; set; }
        public Slot Slot { get; set; }
        [ForeignKey("Slot")]
        [Display(Name = "Slot")]
        public long? SlotId { get; set; }

        public Period Period { get; set; }
        [ForeignKey("Period")]
        [Display(Name = "Period")]
        public long? PeriodId { get; set; }

        public Customer Customer { get; set; }
        [ForeignKey("Customer")]
        [Display(Name = "Customer")]
        public long? CustomerId { get; set; }

        public DateTime Date { get; set; }
    }
}
