using System;
using System.Drawing;

namespace Presentation.ViewInterfaces
{
    public interface IProductView : ISectionViewWithSecondGrid
    {

        event Action<string> SetNewPrice;
        event Action<string, string, string> RemovePrice;

        string Descriprion { set; }
        Image ProductPhoto { set; }
        string PriceError { set; }
        decimal Price { get; }
        
    }
}
