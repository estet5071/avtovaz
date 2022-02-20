using Model.Entities;
using Model.ServiceAbstractions;
using Presentation.AppController;
using Presentation.ViewInterfaces;

namespace Presentation.PresenterAbstractions
{
    abstract internal class BaseSectionPresenterForViewsWithSecondGrid<TView, TEditPresenter, TEntity> : BaseSectionPresenter<TView, TEditPresenter, TEntity> where TView : ISectionViewWithSecondGrid where TEditPresenter : IEditPresenter<TEntity> where TEntity : BaseEntity
    {

        public BaseSectionPresenterForViewsWithSecondGrid(TView view, ISectionService<TEntity> service, IApplicationController controller) : base(view, controller, service)
        {
            _view.ToggleClick += Toggle_Click;
        }


        abstract protected override void UpdateControlsAccordingToRow(int id);
        
        abstract protected override void AddToDataGrid(TEntity entity);

        abstract protected override void UpdateDataGrid();

        private void Toggle_Click()
        {

            if (_view.ToggleState)
            {
                _view.ChangeSecondGridVisible(true);
                _view.ChangeSizeOfMainGrid(_view.SizeOfMainGridWithSecond);
                return;
            }

            _view.ChangeSecondGridVisible(false);
            _view.ChangeSizeOfMainGrid(_view.SizeOfMainGridWithoutSecond);

        }

    }
}
