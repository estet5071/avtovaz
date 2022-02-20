using Unity;
using Presentation.PresenterAbstractions;

namespace Presentation.AppController
{
    public class ApplicationController : IApplicationController
    {
        private readonly UnityContainer container = new UnityContainer();

        public ApplicationController()
        {
            RegisterInstance((IApplicationController)this);
        }


        public IApplicationController RegisterInstance<TImplementation>(TImplementation service)
        {
            container.RegisterInstance(service);
            return this;
            
        }

        public IApplicationController RegisterType<TService, TImplementation>() where TImplementation : TService
        {
            container.RegisterType<TService, TImplementation>();
            return this;
        }



        public void Run<TPresenter>() where TPresenter : IPresenter
        {
            TPresenter presenter = GetPresenter<TPresenter>();
            presenter.Run();
             
        }

        public void Run<TPresenter, TArgument>(TArgument argument) where TPresenter : IPresenter<TArgument>
        {
            TPresenter presenter = GetPresenter<TPresenter>();
            presenter.Run(argument);
        }


        public TPresenter GetPresenter<TPresenter>()
        {
            if (!container.IsRegistered<TPresenter>())
                container.RegisterType<TPresenter>();

            TPresenter presenter = container.Resolve<TPresenter>();
            return presenter;

        }
    }
}
