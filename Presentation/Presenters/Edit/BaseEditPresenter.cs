using Model.Entities;
using Model.ServiceAbstractions;
using Presentation.PresenterAbstractions;
using Presentation.ViewInterfaces.Edit;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Presentation.Presenters.Edit
{
    internal abstract class BaseEditPresenter<TEditView, TEntity> : IEditPresenter<TEntity> where TEditView : ISectionEditView where TEntity : BaseEntity
    {
        protected readonly TEditView _view;
        protected readonly ISectionService<TEntity> _service;

        
        public BaseEditPresenter(TEditView view, ISectionService<TEntity> service)
        {
            _service = service;
            _view = view;

            _view.Apply += EditViewApply;
            _view.Cancel += EditViewCancel;
            
        }


        public event Action<TEntity> AddToDataGrid;
        public event Action UpdateDataGrid;

        public bool ViewIsUpdate { set; protected get; }


        abstract public void ShowDataForUpdate();

        public void ShowForAdd()
        {
            _view.ShowForAdd();
        }


        protected virtual void EditViewApply()
        {
            SetNewData();
            if (IsValid(_service.EntityForAddOrUpdate, out List<ValidationResult> result))
            {
                if (ViewIsUpdate)
                {
                    _service.UpdateEntity();
                    UpdateDataGrid();
                    _view.Hide();
                    return;
                }

                _service.AddToDataBase(_service.EntityForAddOrUpdate);
                 AddToDataGrid(_service.EntityForAddOrUpdate);
                _view.Hide();
                return;

            }
            _view.ShowError(GetErrors(result));
        }


        protected virtual bool IsValid(TEntity entity, out List<ValidationResult> result)
        {
            ValidationContext context = new ValidationContext(entity);
            result = new List<ValidationResult>();
            if (Validator.TryValidateObject(entity, context, result, true))
            {
                return true;
            }
            return false;

        }

      
        protected void EditViewCancel()
        {
            _view.Hide();
        }


        abstract protected void SetNewData();

        private string[] GetErrors(List<ValidationResult> results)
        {
            string[] errors = new string[results.Count];
            for (int i = 0; i < errors.Length; i++)
            {
                errors[i] = results[i].ErrorMessage;
            }
            return errors;
        }


       
    }
}
