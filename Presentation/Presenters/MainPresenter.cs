using System;
using System.Collections.Generic;
using Presentation.PresenterAbstractions;
using Presentation.ViewInterfaces;
using Model.Entities;
using Presentation.AppController;
using Model.Enums;

namespace Presentation.Presenters
{
    class MainPresenter : BasePresenter<IMainView, User>
    {

        private readonly Dictionary<string, Action> _limitAccesser;

        public MainPresenter(IMainView view, IApplicationController controller) : base(view, controller)
        {
            _view.Exit += CloseForm;
            _view.ChangeUser += ChangeUser;
            _view.OpenEmployeeSection += OpenEmployeeSection;
            _view.OpenCustomerSection += OpenCustomerSection;
            _view.OpenProductSection += OpenProductSection;
            _view.OpenOrderSection += OpenOrderSection;
            _view.OpenReportMaker += OpenReportMaker;
            _view.Toggle_Click += Toggle_Click;

            _limitAccesser = new Dictionary<string, Action>() {

            {AccessLevels.SalesManager.GetEnumDescription(), () => SetAccessLimit(false, true, true, true, true) },

            {AccessLevels.Admin.GetEnumDescription(), () => SetAccessLimit(true, true, true, true, true) },

            {AccessLevels.PersonnelManager.GetEnumDescription(), () => SetAccessLimit(true, false, false, false, false) }};

        }

    
        public override void Run(User argument)
        {
            _view.Show();
            
            if(_limitAccesser.TryGetValue(argument.Type, out Action action))
            {
                action();
                _view.UpdateUserInfo(string.Join(" ", argument.IdNavigation.LastName, argument.IdNavigation.Name, argument.IdNavigation.MiddleName) + " | " + argument.IdNavigation.Position);
            }
            else
            {
                SetAccessLimit(false, false, false, false, false);
                _view.UpdateUserInfo("Не удалось определить права доступа, смените пользователя");
            }  
            
        }


        private void SetAccessLimit(bool employee, bool customer, bool product, bool order, bool report)
        {
            _view.EmployeeButtonEnable = employee;
            _view.CustomerButtonEnable = customer;
            _view.ProductButtonEnable = product;
            _view.OrderButtonEnable = order;
            _view.ReportButtonEnable = report;
        }

        

        private void OpenEmployeeSection()
        {
            _controller.Run<EmployeePresenter>();
        }

        private void OpenCustomerSection()
        {
            _controller.Run<CustomerPresenter>();
        }


        private void OpenProductSection()
        {
            _controller.Run<ProductPresenter>();
        }

        private void OpenOrderSection()
        {
            _controller.Run<OrderPresenter>();
        }

        private void OpenReportMaker()
        {
            _controller.Run<ReportPresenter>();
        }


        private void CloseForm()
        {
            _view.Close();
        }

        private void ChangeUser()
        {
            _controller.Run<LoginPresenter>();
            _view.Close();
        }

        private void Toggle_Click()
        {
            if (_view.ToggleState)
            {
                _view.ExitPanelVisible = true;
                _view.SectionPanelVisible = true;
                _view.BrowserSize = _view.SizeBrowserPanelWithMenu;
                _view.BrowserIsFullWindow = false;

            }

            else
            {
                _view.ExitPanelVisible = false;
                _view.SectionPanelVisible = false;
                _view.BrowserIsFullWindow = true;

            }
        }

    }
}
