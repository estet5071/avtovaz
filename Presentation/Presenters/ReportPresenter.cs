using System;
using System.Windows.Forms;
using Model.ServiceAbstractions;
using Presentation.AppController;
using Presentation.PresenterAbstractions;
using Presentation.ViewInterfaces;

namespace Presentation.Presenters
{
    internal class ReportPresenter : BasePresenter<IReportView>
    {

        private readonly IReportService _service;

        public ReportPresenter(IReportView view, IReportService service, IApplicationController controller) : base(view, controller)
        {
            _service = service;
            _view.ChangeReportType += ChangeReportType;
            _view.ChoosePath += ChoosePath;
            _view.UploadReport += UploadReport;
        }

        private void UploadReport()
        {
            DateTime? start;
            DateTime? end;
            if (_view.StartDateTimeEnabled)
                start = _view.StartDateTime;
            else
                start = null;

            if (_view.EndDateTimeEnabled)
                end = _view.EndDateTime;
            else
                end = null;


            if (_service.CreateReport(start, end))
                _view.ShowNotice(false);
            
            else
               _view.ShowNotice(true);
            
        }

        private void ChoosePath()
        {
            using FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowNewFolderButton = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _service.Path = dialog.SelectedPath;
                _view.Path = dialog.SelectedPath;
                return;
            }

            _view.Error = "Неправильный путь";
        }

        private void ChangeReportType(byte numberOfButton)
        {
            _service.ReportType = numberOfButton;
        }
    }
}
