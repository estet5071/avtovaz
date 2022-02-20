using Model.Entities;
using Model.ServiceAbstractions;
using Presentation.ViewInterfaces.Edit;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Presentation.Presenters.Edit
{
    internal class CustomerEditPresenter : BaseEditPresenter<ICustomerEditView, Customer>
    {
        public CustomerEditPresenter(ICustomerEditView view, ICustomerService service ) : base(view, service) { }

        public override void ShowDataForUpdate()
        {
            _view.Name = _service.EntityForAddOrUpdate.Name;
            _view.Phone = _service.EntityForAddOrUpdate.Phone;
            _view.Email = _service.EntityForAddOrUpdate.Email;
            _view.Address = _service.EntityForAddOrUpdate.Adress;
            _view.ShowError(string.Empty);

            _view.Show();
        }


        protected override void SetNewData()
        {
            _service.EntityForAddOrUpdate.Name = _view.Name;
            _service.EntityForAddOrUpdate.Phone = _view.Phone;
            _service.EntityForAddOrUpdate.Email = _view.Email == String.Empty ? null : _view.Email;
            _service.EntityForAddOrUpdate.Adress = _view.Address;
        }

      
        protected override bool IsValid(Customer entity, out List<ValidationResult> result)
        {
            if (!base.IsValid(entity, out result))
                return false;


            if (!ViewIsUpdate)
            {
                if (!((ICustomerService)_service).PhoneIsUnique(entity.Phone))
                {
                    result.Add(new ValidationResult("Такой телефон уже зарегистрирован"));
                    return false;
                }
            }

            

            return true;

        }



    }
}
