using ASPNETCoreWebAPI.DataContext;
using ASPNETCoreWebAPI.Models;

namespace ASPNETCoreWebAPI.Services
{
    public class AddService
    {
        private readonly Context _context;

        public AddService(Context context)
        {
            _context = context;
        }

        public void AddUser(Users users)
        {
            _context.Users.Add(users);
            _context.SaveChanges();
        }

        public void AddAddress(Addresses address)
        {
            _context.Addresses.Add(address);
            _context.SaveChanges();
        }
    }
}
