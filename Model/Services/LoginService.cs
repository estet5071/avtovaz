using Model.ServiceAbstractions;
using Model.Entities;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Model.Services
{
    public class LoginService : ILoginService
    {
        public string Username { get; private set; }
        public string Password { get ; private set ; }
        public string Status { get ; private set ; }

        public bool Login(string userName, string password, out User user)
        {

            using (AvtoVazContext db = new AvtoVazContext())
            {

                user = db.Users.FirstOrDefault(u => u.Login == userName);
                if (user != null)
                {

                    if(PasswordHasher.Verify(password, user.Password))
                    {
                        int id = user.Id;
                        db.Employees.Where(e => e.Id == id).Load();
                        return true;
                    }
                  
                }
                
            }

            Username = string.Empty;
            Password = string.Empty;
            Status = "Неверный логин или пароль";
            return false;
            
        }
    }
}
