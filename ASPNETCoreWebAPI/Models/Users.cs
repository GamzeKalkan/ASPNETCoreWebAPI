using System.ComponentModel.DataAnnotations;

namespace ASPNETCoreWebAPI.Models
{
    public class Users
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }

        public List<Addresses> Address { get; set; }
    }
}
