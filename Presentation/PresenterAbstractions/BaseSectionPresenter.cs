using Presentation.ViewInterfaces;
using Model.Entities;
using Presentation.AppController;
using Model.ServiceAbstractions;

namespace Presentation.PresenterAbstractions
{
    abstract internal class BaseSectionPresenter <TView, TEditPresenter, TEntity> : BasePresenter<TView> where TEntity : BaseEntity where TView : ISectionView where TEditPresenter : IEditPresenter<TEntity>
    {
       
        protected readonly ISectionService<TEntity> _service;
        protected readonly TEditPresenter _editPresenter;

        protected BaseSectionPresenter(TView view, IApplicationController controller, ISectionService<TEntity> service) : base(view, controller )
        {
            _service = service;

            _view.InitialFilling += InitialFilling;
            _view.Edit += (string id) => EditEntity(int.Parse(id));
            _view.Remove += (string id) => RemoveEntity(int.Parse(id));
            _view.ChangeSelectionRow += id => UpdateControlsAccordingToRow(int.Parse(id));

            _editPresenter = controller.GetPresenter<TEditPresenter>();
            _editPresenter.AddToDataGrid += AddToDataGrid;
            _editPresenter.UpdateDataGrid += UpdateDataGrid;

        }

        

        protected void InitialFilling()
        {
            _service.InitialLoad();
            foreach (var item in _service.DataForMainGrid)
            {
                AddToDataGrid(item);
            }
            _service.DataForMainGrid = null;
            
        }
        protected virtual void AddEntity(TEntity entity)
        {
            _service.EntityForAddOrUpdate = entity;
            _editPresenter.ViewIsUpdate = false;
            _editPresenter.ShowForAdd();

        }

        protected void EditEntity(int id)
        {
            _editPresenter.ViewIsUpdate = true;
            TEntity entity = _service.Find(id);
            _service.EntityForAddOrUpdate = entity;
           _editPresenter.ShowDataForUpdate();

        }

        protected void RemoveEntity(int id)
        {
            TEntity entity = _service.Find(id);
            _service.RemoveEntity(entity);
            _view.RemoveFromDataGrid();
            _view.CountOfRow--;
        }


       
        abstract protected void AddToDataGrid(TEntity entity);
        abstract protected void UpdateDataGrid();
        abstract protected void UpdateControlsAccordingToRow(int id);

        

    }
}
