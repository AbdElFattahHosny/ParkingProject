using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParkingProject.Models
{
    public class FeedBacks : CreationandModifications
    {
        public Customer Customer { get; set; }
        [ForeignKey("Customer")]
        [Display(Name = "Customer")]
        public long? CustomerId { get; set; }


        public string Message { get; set; }

        public bool Seen { get; set; }
    }
}
