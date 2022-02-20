using System;
using System.Windows.Forms;
using Model.ServiceAbstractions;
using Model.Services;
using Presentation.ViewInterfaces;
using Presentation.AppController;
using UI.Forms;
using Presentation.Presenters;
using UI.Forms.Edit;
using Presentation.ViewInterfaces.Edit;

namespace UI
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var controller = new ApplicationController()
                .RegisterType<ILoginView, LoginForm>()
                .RegisterType<ILoginService, LoginService>()

                .RegisterType<IMainView, MainForm>()

                .RegisterType<IEmployeeView, EmployeeForm>()
                .RegisterType<IEmployeeEditView, EmployeeEditForm>()
                .RegisterType<ISalaryEditView, SalaryForm>()
                .RegisterInstance((IEmployeeService) new EmployeeService())
                

                .RegisterType<ISectionViewWithSecondGrid, CustomerForm>()
                .RegisterType<ICustomerEditView, CustomerEditForm >()
                .RegisterInstance((ICustomerService) new CustomerService())

                .RegisterType<IProductView, ProductForm>()
                .RegisterType<IProductEditView, ProductEditForm>()
                .RegisterInstance((IProductService) new ProductService())

                .RegisterType<IOrderView, OrderForm>()
                .RegisterType<IOrderEditView, OrderEditForm>()
                .RegisterInstance((IOrderService) new OrderService())

                .RegisterType<IReportView, ReportForm>()
                .RegisterType<IReportService, ReportService>()
                

                .RegisterInstance(new ApplicationContext());
            controller.Run<LoginPresenter>();

           
        }

        
    }
}
