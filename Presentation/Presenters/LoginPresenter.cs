using Presentation.PresenterAbstractions;
using Model.ServiceAbstractions;
using Presentation.ViewInterfaces;
using Model.Entities;
using Presentation.AppController;


namespace Presentation.Presenters
{
    public class LoginPresenter : BasePresenter<ILoginView>
    {
        
        private readonly ILoginService _loginService;
        

        public LoginPresenter(ILoginView view, ILoginService loginService, IApplicationController controller) : base(view, controller)
        {
            _loginService = loginService;
            _view.Login += () => Login(_view.UserName, _view.Password);
        }

        

        private void Login(string userName, string password) 
        {
            
            if(string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                _view.UpdateControls(userName, password, "Заполните все поля");
                return;
            }

            bool result = _loginService.Login(userName.Trim(), password.Trim(), out User user);
            _view.UpdateControls(_loginService.Username, _loginService.Password, _loginService.Status);

            if (result)
            {
                _controller.Run<MainPresenter, User>(user);
                _view.ShowMessage("Вы успешно авторизировались");
                _view.Close();
            }
           
        }

    }
}
