using Presentation.ViewInterfaces;
using Presentation.AppController;

namespace Presentation.PresenterAbstractions
{
    public abstract class BasePresenter<TView> : IPresenter where TView : IView
    {
        protected readonly TView _view;
        protected readonly IApplicationController _controller;

        protected BasePresenter(TView view, IApplicationController controller)
        {
            _view = view;
            _controller = controller;
        }

        public void Run()
        {
            _view.Show();
        }

    }


    public abstract class BasePresenter<TView, TArgument> : IPresenter<TArgument> where TView : IView
    {
        protected readonly TView _view;
        protected readonly IApplicationController _controller;

        public BasePresenter(TView view, IApplicationController controller)
        {
            _view = view;
            _controller = controller;
        }

        public abstract void Run(TArgument argument);
        
    }
}
