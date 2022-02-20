using Model.Entities;

namespace Model.ServiceAbstractions
{
    public interface ILoginService
   {
        string Username { get;}
        string Password { get;}
        string Status { get;}

        public bool Login(string userName, string password, out User user);
    }
}
