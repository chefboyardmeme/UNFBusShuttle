using System.ComponentModel.DataAnnotations;

namespace UNFBusShuttle.Models
{
    public class User
    {

        [Key]
        public int Id { get; set; }
        public string? fName { get; set; }
        public string? lName { get; set; }
        public string? email { get; set; }
        public string? password { get; set; }
        public string? role { get; set; }
       
    }
}
