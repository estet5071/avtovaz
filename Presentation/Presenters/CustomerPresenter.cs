using System.Linq;
using Model.Entities;
using Model.ServiceAbstractions;
using Presentation.AppController;
using Presentation.PresenterAbstractions;
using Presentation.ViewInterfaces;
using Presentation.Presenters.Edit;

namespace Presentation.Presenters
{
    internal class CustomerPresenter : BaseSectionPresenterForViewsWithSecondGrid<ISectionViewWithSecondGrid, CustomerEditPresenter, Customer>
    {
        
        public CustomerPresenter(ISectionViewWithSecondGrid view, IApplicationController controller, ICustomerService service) : base(view, service, controller)
        {
            _view.Add += () => AddEntity(new Customer());
        }



        protected override void UpdateControlsAccordingToRow(int id)
        {
            _view.ClearSecondGrid();
            if (id == 0)
                return;
          var orders = _service.Find(id).Orders.ToArray();
            foreach (var item in orders)
            {
                _view.AddDataToSecondGrid(item.Id.ToString(), $"{item.Employee.LastName} {item.Employee.Name} {item.Employee.MiddleName}", item.DateCreate.ToShortDateString(), item.DateClose?.ToShortDateString() ?? "нет данных", item.OrderProducts.Count.ToString(), item.Status == true ? "открыт": "закрыт");
            }
            
        }


        protected override void AddToDataGrid(Customer entity)
        {
            _view.AddToDataGrid(entity.Id.ToString(), entity.Name, entity.Phone, entity.Email ?? "нет данных", entity.Adress);
            _view.CountOfRow++;
        }

        protected override void UpdateDataGrid()
        {
            _view.UpdateDataGrid(_service.EntityForAddOrUpdate.Id.ToString(), _service.EntityForAddOrUpdate.Name, _service.EntityForAddOrUpdate.Phone, _service.EntityForAddOrUpdate.Email ?? "нет данных", _service.EntityForAddOrUpdate.Adress);
        }
    }
}
