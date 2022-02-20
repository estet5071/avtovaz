using Model.Entities;
using Model.ServiceAbstractions;
using Presentation.ViewInterfaces.Edit;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Presentation.Presenters.Edit
{
    internal class EmployeeEditPresenter : BaseEditPresenter<IEmployeeEditView, Employee>
    {
        public EmployeeEditPresenter(IEmployeeService service, IEmployeeEditView view) : base(view, service)
        {
            _view.LoadPhoto += LoadPhotoFromEditView;
            _view.RemovePhoto += RemovePhotoFromEditView;
        }


        public override void ShowDataForUpdate()
        {
            FillComboBoxs();
            _view.Position = _service.EntityForAddOrUpdate.Position;
            _view.FirstName = _service.EntityForAddOrUpdate.Name;
            _view.LastName = _service.EntityForAddOrUpdate.LastName;
            _view.MiddleName = _service.EntityForAddOrUpdate.MiddleName;
            _view.Adress = _service.EntityForAddOrUpdate.Adress;
            _view.Phone = _service.EntityForAddOrUpdate.Phone;
            _view.Email = _service.EntityForAddOrUpdate.Email;
            _view.Birthday = _service.EntityForAddOrUpdate.Birthday;
            _view.Login = _service.EntityForAddOrUpdate.User?.Login;
            _view.Password = _service.EntityForAddOrUpdate.User?.Password;
            _view.AccountAcces = _service.EntityForAddOrUpdate.User?.Type;
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

        internal void FillComboBoxs()
        {
            _view.FillComboBoxs(((IEmployeeService)_service).GetAccessLevels(), ((IEmployeeService)_service).GetEmployeePositions());
        }


        protected override void SetNewData()
        {
            _service.EntityForAddOrUpdate.Position = _view.Position;
            _service.EntityForAddOrUpdate.Name = _view.FirstName;
            _service.EntityForAddOrUpdate.LastName = _view.LastName;
            _service.EntityForAddOrUpdate.MiddleName = _view.MiddleName;
            _service.EntityForAddOrUpdate.Adress = _view.Adress == string.Empty ? null : _view.Adress;
            _service.EntityForAddOrUpdate.Phone = _view.Phone;
            _service.EntityForAddOrUpdate.Email = _view.Email == string.Empty ? null : _view.Email;
            _service.EntityForAddOrUpdate.Birthday = _view.Birthday;

            if (string.IsNullOrEmpty(_view.Login) || string.IsNullOrEmpty(_view.Password) || string.IsNullOrEmpty(_view.AccountAcces))
            {
                _service.EntityForAddOrUpdate.User = null;
                return;
            }

            if (_service.EntityForAddOrUpdate.User == null)
                _service.EntityForAddOrUpdate.User = new User();

            _service.EntityForAddOrUpdate.User.Login = _view.Login;
            _service.EntityForAddOrUpdate.User.Password = ((IEmployeeService)_service).GetHashPassword(_view.Password);
            _service.EntityForAddOrUpdate.User.Type = _view.AccountAcces;
        }


       protected override bool IsValid(Employee entity, out List<ValidationResult> result)
        {
           if( ! base.IsValid(entity, out result))
                return false;

            if (!ViewIsUpdate)
            {
                if (!((IEmployeeService)_service).PhoneIsUnique(entity.Phone))
                {
                    result.Add(new ValidationResult("Такой телефон уже зарегистрирован"));
                    return false;
                }

                if (!((IEmployeeService)_service).LoginIsUnique(entity.User?.Login))
                {
                    result.Add(new ValidationResult("указанный логин занят"));
                    return false;
                }

            }


            return true;

        } 


        private void LoadPhotoFromEditView()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _view.Photo = Image.FromFile(dialog.FileName);
                _service.EntityForAddOrUpdate.Photo = File.ReadAllBytes(dialog.FileName);
            }

        }


        private void RemovePhotoFromEditView()
        {
            _view.Photo = null;
            _service.EntityForAddOrUpdate.Photo = null;
        }

        

    }
}
