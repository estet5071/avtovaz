using Presentation.PresenterAbstractions;
using Presentation.ViewInterfaces;
using Presentation.AppController;
using Model.ServiceAbstractions;
using Model.Entities;
using System.IO;
using System.Drawing;
using Presentation.Presenters.Edit;

namespace Presentation.Presenters
{
    internal class EmployeePresenter : BaseSectionPresenter<IEmployeeView, EmployeeEditPresenter, Employee>
    {

        public EmployeePresenter(IEmployeeView view, IApplicationController controller, IEmployeeService service) : base(view, controller, service)
        {
            _view.Add += () => AddEntity(new Employee());
            _view.SalaryButtonClick += id =>  SalaryButtonClick(int.Parse(id));
        }

       
        protected override void AddEntity(Employee entity)
        {
           _editPresenter.FillComboBoxs();
            base.AddEntity(entity);

        }


        protected override void UpdateControlsAccordingToRow(int id)
        {
            if(id == 0)
            {
                _view.EmployeePhoto = null;
                return;
            }
                

            byte[] photo = _service.Find(id).Photo;
            if (photo == null)
            {
                _view.EmployeePhoto = null;
                return;
            }


            using MemoryStream stream = new MemoryStream(photo);
            _view.EmployeePhoto = Image.FromStream(stream);

        }


        protected override void AddToDataGrid(Employee entity)
        {
            _view.AddToDataGrid(entity.Id.ToString(), $"{entity.LastName} {entity.Name} {entity.MiddleName}", entity.Adress ?? "нет данных", entity.Email ?? "нет данных", entity.Phone, entity.Birthday?.ToShortDateString() ?? "нет данных", entity.User?.Type ?? "нет аккаунта", entity.Position);
            _view.CountOfRow++;
        }

        protected override void UpdateDataGrid()
        {
            _view.UpdateDataGrid(_service.EntityForAddOrUpdate.Id.ToString(), $"{_service.EntityForAddOrUpdate.LastName} {_service.EntityForAddOrUpdate.Name} {_service.EntityForAddOrUpdate.MiddleName}", _service.EntityForAddOrUpdate.Adress ?? "нет данных", _service.EntityForAddOrUpdate.Email ?? "нет данных", _service.EntityForAddOrUpdate.Phone, _service.EntityForAddOrUpdate.Birthday?.ToShortDateString() ?? "нет данных", _service.EntityForAddOrUpdate.User?.Type ?? "нет аккаунта", _service.EntityForAddOrUpdate.Position);
        }

        private void SalaryButtonClick(int id)
        {
            _controller.Run<SalaryEditPresenter, Employee>(_service.Find(id));
        }
    }
}
