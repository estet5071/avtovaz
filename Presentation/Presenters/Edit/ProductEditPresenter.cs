using Model.Entities;
using Model.ServiceAbstractions;
using Presentation.ViewInterfaces.Edit;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Presentation.Presenters.Edit
{
    internal class ProductEditPresenter : BaseEditPresenter<IProductEditView, Product>
    {
        public ProductEditPresenter(IProductEditView view, IProductService service) : base(view, service)
        {

            _view.CarModelChange += ChangeInfoInComboBoxsAccordingToCarModel;
            _view.LoadPhoto += LoadPhoto;
            _view.RemovePhoto += RemovePhoto;
        }

        public override void ShowDataForUpdate()
        {
            _view.CarModel = _service.EntityForAddOrUpdate.Model;
            _view.CarBodys = _service.EntityForAddOrUpdate.BodyType;
            _view.CarColor = _service.EntityForAddOrUpdate.Color;
            _view.Description = _service.EntityForAddOrUpdate.Description;
            _view.DateCreate = _service.EntityForAddOrUpdate.DateCreate;
            _view.CarKit = _service.EntityForAddOrUpdate.Kit;
            _view.ShowError(string.Empty);

            if (_service.EntityForAddOrUpdate.Photo != null)
            {
                using MemoryStream stream = new MemoryStream(_service.EntityForAddOrUpdate.Photo);
                _view.Photo = Image.FromStream(stream);
            }
            else
            {
                _view.Photo = null;
            }

            _view.Show();
        }

        protected override void SetNewData()
        {
            _service.EntityForAddOrUpdate.Model = _view.CarModel;
            _service.EntityForAddOrUpdate.BodyType = _view.CarBodys;
            _service.EntityForAddOrUpdate.Color = _view.CarColor;
            _service.EntityForAddOrUpdate.Description = _view.Description == string.Empty ?  null : _view.Description;
            _service.EntityForAddOrUpdate.DateCreate = _view.DateCreate;
            _service.EntityForAddOrUpdate.Kit = _view.CarKit;
        }

        private void LoadPhoto()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _view.Photo = Image.FromFile(openFileDialog.FileName);
                _service.EntityForAddOrUpdate.Photo = File.ReadAllBytes(openFileDialog.FileName);
            }
        }

        private void RemovePhoto()
        {
            _view.Photo = null;
            _service.EntityForAddOrUpdate.Photo = null;
        }


        private void ChangeInfoInComboBoxsAccordingToCarModel(int modelIndex)
        {
            if (modelIndex == -1)
                return;
            _view.AddCarColorsToComboBox(((IProductService)_service).GetCarColors(modelIndex));
            _view.AddCarBodysToComboBox(((IProductService)_service).GetCarBodys(modelIndex));
        }


    }
}
