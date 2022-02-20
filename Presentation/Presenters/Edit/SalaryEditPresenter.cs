using Model.Entities;
using Model.ServiceAbstractions;
using Presentation.AppController;
using Presentation.PresenterAbstractions;
using Presentation.ViewInterfaces.Edit;
using System;

namespace Presentation.Presenters.Edit
{
    internal class SalaryEditPresenter : BasePresenter<ISalaryEditView, Employee>
    {

        private readonly IEmployeeService _service;
        public SalaryEditPresenter(ISalaryEditView view, IApplicationController controller, IEmployeeService service) : base(view, controller)
        {
            _service = service;
            _view.Calculate += CalculateTaxAndResult;
            _view.Apply += Apply_Click;
            _view.Cancel += Cancel_Click;
        }


        public override void Run(Employee argument)
        {
            if (argument.Wage == null)
                argument.Wage = new Wage();
            _service.EntityForAddOrUpdate = argument;
            _view.DaySalary = argument.Wage.DaySalary;
            _view.PrizeRatio = argument.Wage.PrizeRatio;
            _view.WorkDays = argument.Wage.WorkDays;
            _view.TaxDeduction = argument.Wage.TaxDeduction;
            CalculateTaxAndResult();
            _view.Show();

        }

        private void Cancel_Click()
        {
            _view.Close();
        }

        private void Apply_Click()
        {
            try
            {
                _service.EntityForAddOrUpdate.Wage.DaySalary = _view.DaySalary;
                _service.EntityForAddOrUpdate.Wage.PrizeRatio = _view.PrizeRatio;
                _service.EntityForAddOrUpdate.Wage.WorkDays = _view.WorkDays;
                _service.EntityForAddOrUpdate.Wage.TaxDeduction = _view.TaxDeduction;
                _service.UpdateEntity();
                _view.Close();
            }

            catch(InvalidCastException ex)
            {
                _view.Error = ex.Message;
            }
            
        }

        private void CalculateTaxAndResult()
        {
            try
            {
                (decimal result, decimal tax) = _service.GetResultAndTax(_view.DaySalary, _view.PrizeRatio, _view.WorkDays, _view.TaxDeduction);
                _view.Tax = tax;
                _view.Result = result;
                _view.Error = string.Empty;
            }
            catch (InvalidCastException ex)
            {
                _view.Error = ex.Message;
            }

        }

      
    }
}
