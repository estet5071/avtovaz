using System;

namespace Presentation.ViewInterfaces
{
    public interface IReportView : IView
    {

        event Action<byte> ChangeReportType;
        event Action ChoosePath;
        event Action UploadReport;

        string Path { set; }
        string Error { set; }
        DateTime StartDateTime { get; }
        DateTime EndDateTime { get; }
        bool StartDateTimeEnabled { get; }
        bool EndDateTimeEnabled { get; }


        void ShowNotice(bool isError);

    }
}
