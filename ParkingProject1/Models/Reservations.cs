using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParkingProject11.Models
{
    public class Reservations : CreationandModifications
    {

        public Area Area { get; set; }
        [ForeignKey("Area")]
        [Display(Name = "Area")]
        public long? AreaId { get; set; }
        public Slot Slot { get; set; }
        [ForeignKey("Slot")]
        [Display(Name = "Slot")]
        public long? SlotId { get; set; }

        public Customer Customer { get; set; }
        [ForeignKey("Customer")]
        [Display(Name = "Customer")]
        public long? CustomerId { get; set; }

        public DateTime From { get; set; }

        public DateTime To { get; set; }

        public int TotalHours { get; set; }

        public int TotalCost { get; set; }




    }
}
