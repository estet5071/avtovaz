using System;

namespace Model.ServiceAbstractions
{
    public interface IReportService
    {

         byte ReportType { set; }
         string Path { set; }

         bool CreateReport(DateTime? start, DateTime? end);


    }
}
