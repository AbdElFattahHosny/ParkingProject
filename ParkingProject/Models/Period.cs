using System.ComponentModel.DataAnnotations;

namespace ParkingProject.Models
{
    public class Period : CreationandModifications
    {
      
        public int Number { get; set; }

        [Range(1,12,ErrorMessage ="From 1 to 12 Only")]
        public int From { get; set; }

        [Range(1, 12, ErrorMessage = "From 1 to 12 Only")]
        public int To { get; set; }

    }
}
