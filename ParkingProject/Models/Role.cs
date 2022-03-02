using System.Collections.Generic;

namespace ParkingProject.Models
{
    public class Role : CreationandModifications
    {
        public string Name { get; set; }

        public ICollection<Users> Users { get; set; }

        public ICollection<Customer> Customers { get; set; }

    }
}
