using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ParkingProject11.Models
{
    public class Area : CreationandModifications
    {
     
        public char Name { get; set; }

        public ICollection<Slot> Slots { get; set; }

       

        public ICollection<Reservations> Reservations { get; set; }





    }
}
