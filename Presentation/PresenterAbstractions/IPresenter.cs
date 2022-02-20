namespace Presentation.PresenterAbstractions
{
    public interface IPresenter
    {
       void Run();
    }

   public interface IPresenter<T>
    {
        void Run(T argument);
    }
}
