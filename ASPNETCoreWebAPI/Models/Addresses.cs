using System.ComponentModel.DataAnnotations;

namespace ASPNETCoreWebAPI.Models
{
    public class Addresses
    {
        [Key]
        public int Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public int UserId { get; set; }
        public Users Users { get; set; }
    }
}
