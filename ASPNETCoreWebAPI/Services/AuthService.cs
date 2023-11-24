using ASPNETCoreWebAPI.Models;

namespace ASPNETCoreWebAPI.Services
{
    public class AuthService
    {
        public bool ValidateCredentials(Users user)
        {

            return user.Mail == "example" && user.Password == "password";
        }
    }
}
