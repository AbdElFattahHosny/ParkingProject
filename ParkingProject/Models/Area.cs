using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ParkingProject.Models
{
    public class Area : CreationandModifications
    {
     
        public char Name { get; set; }

        public ICollection<Slot> Slots { get; set; }

        public ICollection<BusySlots> BusySlots { get; set; }

        public ICollection<Reservations> Reservations { get; set; }





    }
}
