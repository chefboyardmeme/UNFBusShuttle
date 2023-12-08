using System.ComponentModel.DataAnnotations;

namespace UNFBusShuttle.Models
{
    public class Admin : User
    {
        
        public int adminCode { get; set; }
        
}
}
