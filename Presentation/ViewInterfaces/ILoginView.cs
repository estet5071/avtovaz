using System;

namespace Presentation.ViewInterfaces
{
    public interface ILoginView : IView
    {

      event Action Login;

      string UserName { get;}
      string Password { get;}

      void UpdateControls(string userName, string password, string errorMessage);
      void ShowMessage(string message);
    }
}
