using System;

namespace Presentation.ViewInterfaces.Edit
{
    public interface ISalaryEditView : IView
    {

        event Action Cancel;
        event Action Apply;
        event Action Calculate;

        decimal DaySalary { get; set; }
        double PrizeRatio { get; set; }
        int WorkDays { get; set; }
        decimal TaxDeduction { get; set; }
        decimal Tax { set; }
        decimal Result { set; }
        string Error { set; }



    }
}
