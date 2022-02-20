using System;
using System.Drawing;

namespace Presentation.ViewInterfaces
{
    public interface IMainView : IView
    {

        event Action Toggle_Click;
        event Action OpenEmployeeSection;
        event Action OpenCustomerSection;
        event Action OpenProductSection;
        event Action OpenOrderSection;
        event Action OpenReportMaker;

        event Action Exit;
        event Action ChangeUser;

        bool BrowserIsFullWindow { set; }
        Size BrowserSize { set; }
        Size SizeBrowserPanelWithMenu { get; }
        bool EmployeeButtonEnable { set; }
        bool CustomerButtonEnable { set; }
        bool ProductButtonEnable { set; }
        bool OrderButtonEnable { set; }
        bool ReportButtonEnable { set; }
        bool ToggleState { get; }
        bool SectionPanelVisible { set; }
        bool ExitPanelVisible { set; }

        void UpdateUserInfo(string userInfo);
    }
}
