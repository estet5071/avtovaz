namespace Presentation.ViewInterfaces
{
    public interface IOrderView : ISectionViewWithSecondGrid
    {

        decimal ProductSumm { set; }
        string Error { set; }
    }
}
