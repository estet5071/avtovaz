using System.Collections.Generic;
using System.Linq;
using Model.Entities;
using Model.ServiceAbstractions;
using Presentation.AppController;
using Presentation.PresenterAbstractions;
using Presentation.Presenters.Edit;
using Presentation.ViewInterfaces;

namespace Presentation.Presenters
{
    internal class OrderPresenter : BaseSectionPresenterForViewsWithSecondGrid<IOrderView, OrderEditPresenter, Order>
    {

        public OrderPresenter(IOrderView view, IOrderService service, IApplicationController controller) : base(view, service, controller)
        {
            _view.Add += () => AddEntity(new Order());
            _editPresenter.ShowError += ShowError;
        }


        protected override void AddEntity(Order entity)
        {
            _view.Error = string.Empty;
            _service.EntityForAddOrUpdate = entity;
            _editPresenter.ViewIsUpdate = false;
            if (_editPresenter.TryFillComboBoxs() == false)
                return;
            _editPresenter.UpdateGridsInEditView();
            _editPresenter.ShowForAdd();
        }


        protected override void UpdateControlsAccordingToRow(int id)
        {
            _view.ClearSecondGrid();
            if (id == 0)
                return;

            List<Product> products = _service.Find(id).OrderProducts.Select(op => op.Product).ToList();
            decimal summ = 0;
            foreach (var product in products)
            {
               var lasDateChange = product.ProductPrices.Max(pp => pp.DateChange.ToString());
              decimal? price = product.ProductPrices.FirstOrDefault(pp => pp.DateChange.ToString() == lasDateChange)?.Value;
                _view.AddDataToSecondGrid(product.Id.ToString(), product.Model, product.BodyType, product.Color, product.Kit, product.DateCreate.ToShortDateString(), price?.ToString() ?? "цена не установлена" );
                summ += price ?? 0;
            }

            _view.ProductSumm = summ;
              
        }

        protected override void AddToDataGrid(Order entity)
        {
            _view.AddToDataGrid(entity.Id.ToString(), $"{entity.Employee.LastName} {entity.Employee.Name}", $"{entity.Customer.Name}", entity.DateCreate.ToString(), entity.DateClose?.ToString() ?? "заказ не закрыт", entity.OrderProducts.Count.ToString(), entity.Status == true ? "открыт" : "закрыт");
            _view.CountOfRow++;
        }

        protected override void UpdateDataGrid()
        {
            _view.UpdateDataGrid(_service.EntityForAddOrUpdate.Id.ToString(), $"{_service.EntityForAddOrUpdate.Employee.LastName} {_service.EntityForAddOrUpdate.Employee.Name}", $"{_service.EntityForAddOrUpdate.Customer.Name}", _service.EntityForAddOrUpdate.DateCreate.ToString(), _service.EntityForAddOrUpdate.DateClose?.ToString() ?? "заказ открыт", _service.EntityForAddOrUpdate.OrderProducts.Count.ToString(), _service.EntityForAddOrUpdate.Status == true ? "открыт" : "закрыт");
        }

        private void ShowError(string error)
        {
            _view.Error = error;
        }
    }
}
