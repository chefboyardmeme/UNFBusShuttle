using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UNFBusShuttle.Models
{
    public class Schedule
    {
        [Key] public int schedId { get; set; }
        public DateTime? depTime { get; set; }
        public DateTime? arrTime { get; set; }
        public string? destination { get; set; }


        [ForeignKey("Admin")] 
        public int adminCode { get; set; }
        

    }
}
