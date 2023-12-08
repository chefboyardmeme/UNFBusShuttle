using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UNFBusShuttle.Models
{
    public class Driver : User
    {
        
        public int busNumber { get; set; }
        [ForeignKey("Schedule")]
        public int schedId { get; set; }
        public bool? status { get; set; }
        
    }
}
