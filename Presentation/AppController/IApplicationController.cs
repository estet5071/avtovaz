using Presentation.PresenterAbstractions;

namespace Presentation.AppController
{
    public interface IApplicationController
    {

        IApplicationController RegisterType<TService, TImplementation>() where TImplementation : TService;

        IApplicationController RegisterInstance<TImplementation>(TImplementation service);

        void Run<TPresenter>() where TPresenter : IPresenter;

        void Run<TPresenter, TArgument>(TArgument argument) where TPresenter : IPresenter<TArgument>;

        TPresenter GetPresenter<TPresenter>();
    }
}
