using Model.Entities;
using Model.ServiceAbstractions;
using Presentation.ViewInterfaces.Edit;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Presentation.Presenters.Edit
{
    internal class OrderEditPresenter : BaseEditPresenter<IOrderEditView, Order>
    {

        private readonly List<int> _productsIdForAddWhenUpdate = new List<int>();
        private readonly List<int> _productsIdForRemoveWhenUpdate = new List<int>();

        public OrderEditPresenter(IOrderEditView view, IOrderService service) : base(view, service)
        {
            _view.AddProductToBasket += AddProductToBasket;
            _view.RemoveProductFromBasket += RemoveProductFromBasket;
        }

       internal event Action<string> ShowError;



        public override void ShowDataForUpdate()
        {
            if (_service.EntityForAddOrUpdate.Status)
            {
                ShowError(string.Empty);
            }
            else
            {
                ShowError("редактирование закрытого заказа невозможно");
                return;
            }


            TryFillComboBoxs();
            _view.ShowError(string.Empty);
            _view.OrderStatus = _service.EntityForAddOrUpdate.Status;
            _view.DateCreate = _service.EntityForAddOrUpdate.DateCreate;
            _view.Client = _service.EntityForAddOrUpdate.Customer.Name;
            _view.Employee = _service.EntityForAddOrUpdate.Employee.LastName + ' ' + _service.EntityForAddOrUpdate.Employee.Name + ' ' + _service.EntityForAddOrUpdate.Employee.MiddleName;
            _view.OrderSum = _service.EntityForAddOrUpdate.Sum;

            UpdateGridsInEditView();

            var products = _service.EntityForAddOrUpdate.OrderProducts.Select(op => op.Product).ToList();
            foreach (var product in products)
            {
                _view.AddToBasketGrid(product.Id.ToString(), product.Model, product.BodyType, product.Color, product.Kit, product.DateCreate.ToShortDateString(), product.ProductPrices.Last().Value.ToString());
            }
            _view.Show();
        }

        internal void UpdateGridsInEditView()
        {
            _view.ClearBasketGrid();
            _view.ClearProductGrid();
            Product[] products = ((IOrderService)_service).GetAllProducts();

            foreach (Product product in products)
            {
                _view.AddToProductsGrid(product.Id.ToString(), product.Model, product.BodyType, product.Color, product.Kit, product.DateCreate.ToShortDateString(), product.ProductPrices.LastOrDefault()?.Value.ToString() ?? "цена не установлена");
            }

        }

        internal bool TryFillComboBoxs()
        {
            _view.ClearItemsOfComboBoxs();
            var employees = ((IOrderService)_service).GetEmployees().Select(e => new { FullName = $"{e.LastName} {e.Name} {e.MiddleName}" });
            var clients = ((IOrderService)_service).GetCustomers();

            if (employees.Count() == 0)
            {
                ShowError("нет работников");
                return false;
            }

            if (clients.Length == 0)
            {
                ShowError("нет клиентов");
                return false;
            }

            _view.AddEmployeesToComboBox(employees.Select(e => e.FullName).ToArray());
            _view.AddCustomersToComboBox(clients.Select(c => c.Name).ToArray());
            return true;
        }

        protected override void EditViewApply()
        {
            base.EditViewApply();

            if (_productsIdForAddWhenUpdate.Count != 0)
                _productsIdForAddWhenUpdate.Clear();

            if (_productsIdForRemoveWhenUpdate.Count != 0)
                _productsIdForRemoveWhenUpdate.Clear();
        }


        protected override void SetNewData()
        {
            _service.EntityForAddOrUpdate.Status = _view.OrderStatus;
            _service.EntityForAddOrUpdate.DateCreate = _view.DateCreate;
            _service.EntityForAddOrUpdate.Sum = _view.OrderSum;
            if (_view.OrderStatus == false)
                _service.EntityForAddOrUpdate.DateClose = DateTime.Now;

            _service.EntityForAddOrUpdate.Customer = _view.Client == String.Empty ? null : ((IOrderService)_service).FindCustomer(_view.Client);
            _service.EntityForAddOrUpdate.Employee = _view.Employee == String.Empty ? null : ((IOrderService)_service).FindEmployee(_view.Employee);

            if (ViewIsUpdate)
            {

                ChangeProductsIfUpdate();
                return;
            }

            var productsId = _view.GetIdOfProductsInBasket();
            foreach (var productId in productsId)
            {
                _service.EntityForAddOrUpdate.OrderProducts.Add(new OrderProduct() { Order = _service.EntityForAddOrUpdate, ProductId = productId });
            }
        }

        private void AddProductToBasket()
        {
            string[] product = _view.GetProductForAddToBasketGrid();
            if (decimal.TryParse(product[6], out decimal price))
            {
                if (ViewIsUpdate)
                    _productsIdForAddWhenUpdate.Add(int.Parse(product[0]));

                _view.AddToBasketGrid(product);
                _view.OrderSum += price;
                return;
            }

            _view.ShowError("невозможно добавить товар без цены");
        }

        private void RemoveProductFromBasket()
        {
            int id = _view.RemoveFromBasketGrid(out decimal price);
            if (id == 0)
                return;

            _view.OrderSum -= price;

            if (ViewIsUpdate)
                _productsIdForRemoveWhenUpdate.Add(id);

        }

       

        private void ChangeProductsIfUpdate()
        {
            foreach (var productId in _productsIdForAddWhenUpdate)
            {
                _service.EntityForAddOrUpdate.OrderProducts.Add(new OrderProduct() { OrderId = _service.EntityForAddOrUpdate.Id, ProductId = productId });
            }

            foreach (var productId in _productsIdForRemoveWhenUpdate)
            {
                OrderProduct product = _service.EntityForAddOrUpdate.OrderProducts.First(op => op.ProductId == productId && op.OrderId == _service.EntityForAddOrUpdate.Id);
                _service.EntityForAddOrUpdate.OrderProducts.Remove(product);

            }

        }


    }
}
