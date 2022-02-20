using System;
using Model.Entities;
using Model.ServiceAbstractions;
using Presentation.AppController;
using Presentation.PresenterAbstractions;
using Presentation.ViewInterfaces;
using System.Linq;
using System.IO;
using System.Drawing;
using Presentation.Presenters.Edit;

namespace Presentation.Presenters
{
    internal class ProductPresenter : BaseSectionPresenterForViewsWithSecondGrid<IProductView, ProductEditPresenter, Product>
    {
        public ProductPresenter(IProductView view, IProductService service, IApplicationController controller) : base(view, service, controller)
        {
            _view.Add += () => AddEntity(new Product());
            _view.SetNewPrice += id => CreateNewPriceForProduct(int.Parse(id));
            _view.RemovePrice += (ProductId, dateCreate, value) => DeletePrice(int.Parse(ProductId), DateTime.Parse(dateCreate), decimal.Parse(value));

        }

      
        protected override void UpdateControlsAccordingToRow(int id)
        {
            _view.ClearSecondGrid();
            if (id == 0)
                return;
            Product product = _service.Find(id);
           var prices = product.ProductPrices.ToList();
            foreach (var pr in prices)
            {
                _view.AddDataToSecondGrid(pr.DateChange.ToString(), pr.Value.ToString());
            }

            _view.Descriprion = product.Description;

            if (product.Photo == null)
            {
                _view.ProductPhoto = null;
                return;
            }

            using MemoryStream stream = new MemoryStream(product.Photo);
            _view.ProductPhoto = Image.FromStream(stream);
        }


        protected override void AddToDataGrid(Product entity)
        {
            _view.AddToDataGrid(entity.Id.ToString(), entity.Model, entity.BodyType, entity.Color, entity.Kit, entity.DateCreate.ToShortDateString());
            _view.CountOfRow++;
        }
       
        protected override void UpdateDataGrid()
        {
            _view.UpdateDataGrid(_service.EntityForAddOrUpdate.Id.ToString(), _service.EntityForAddOrUpdate.Model, _service.EntityForAddOrUpdate.BodyType, _service.EntityForAddOrUpdate.Color, _service.EntityForAddOrUpdate.Kit, _service.EntityForAddOrUpdate.DateCreate.ToShortDateString());
        }


        private void DeletePrice(int ProductId, DateTime dateCreate, decimal value)
        {
            Product product = _service.Find(ProductId);
            ProductPrice price = product.ProductPrices.FirstOrDefault(p => p.DateChange.Date == dateCreate.Date && p.DateChange.Hour == dateCreate.Hour && p.DateChange.Minute == dateCreate.Minute && p.Value == value);
            product.ProductPrices.Remove(price);
            _service.UpdateEntity();
            _view.RemoveFromSecondGrid();

        }


        private void CreateNewPriceForProduct(int ProductId)
        {
            var prices = _service.Find(ProductId).ProductPrices;
            try
            {
                ProductPrice price = new ProductPrice() { Value = _view.Price, DateChange = DateTime.Now };
                prices.Add(price);
                _service.UpdateEntity();
                _view.AddDataToSecondGrid(price.DateChange.ToString(), price.Value.ToString());
                _view.PriceError = String.Empty;

            }
            catch (InvalidCastException exc)
            {
                _view.PriceError = exc.Message;
            }

        }

    }
}
