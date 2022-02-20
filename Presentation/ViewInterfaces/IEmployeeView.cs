using System;
using System.Drawing;

namespace Presentation.ViewInterfaces
{
    public interface IEmployeeView : ISectionView
    {

       event Action<string> SalaryButtonClick;
       Image EmployeePhoto { set; }
    }
}
