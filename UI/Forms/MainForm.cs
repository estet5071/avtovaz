using System;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Forms;
using Presentation.ViewInterfaces;
using CefSharp.WinForms;
using CefSharp;


namespace UI.Forms
{
    public partial class MainForm : MetroForm, IMainView
    {

        private readonly ApplicationContext _context;


        public MainForm(ApplicationContext context)
        {
            InitializeComponent();
            _context = context;
             InitializeChromium();
        }

        public event Action Toggle_Click;
        public event Action OpenEmployeeSection;
        public event Action OpenCustomerSection;
        public event Action OpenProductSection;
        public event Action OpenOrderSection;
        public event Action OpenReportMaker;
        public event Action ChangeUser;
        public event Action Exit;
        

        public bool EmployeeButtonEnable { set => empoyeesButton.Enabled = value; }
        public bool CustomerButtonEnable { set => customersButton.Enabled = value; }
        public bool ProductButtonEnable { set => productButton.Enabled = value; }
        public bool OrderButtonEnable { set => orderButton.Enabled = value; }
        public bool ReportButtonEnable { set => unloadReportButton.Enabled = value; }
        public bool ToggleState => metroToggle.Checked;
        public bool SectionPanelVisible { set => sectionButtonsPanel.Visible = value; }
        public bool ExitPanelVisible { set => exitAndChangeUserPanel.Visible = value; }
        public Size SizeBrowserPanelWithMenu => new Size((int) (this.Size.Width / 1.1), (int) (this.Size.Height / 1.15));
        public Size BrowserSize { set => browserPanel.Size = value; }
        public bool BrowserIsFullWindow
        {
            set
            {
                if (value)
                {
                    browserPanel.Dock = DockStyle.Fill;
                }
                else
                {
                    browserPanel.Dock = DockStyle.None;
                    browserPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                }
            }

        }

     

        public new void Show()
        {
             base.Show();
            _context.MainForm = this;
        }

        public void UpdateUserInfo(string userInformation)
        {
            userInfo.Text = userInformation;
        }

        private void MetroToggle_CheckStateChanged(object sender, EventArgs e)
        {
            Toggle_Click();
        }

        private void InitializeChromium()
        {
            if (!Cef.IsInitialized)
            {
                CefSettings settings = new CefSettings();
                settings.CefCommandLineArgs.Add("disable-threaded-scrolling", "1");
                Cef.Initialize(settings);
            }

            var browser = new ChromiumWebBrowser("www.lada.ru/");
            browserPanel.Controls.Add(browser);

        }

        private void EmpoyeesButton_Click(object sender, EventArgs e)
        {
            OpenEmployeeSection();
        }

        private void CustomersButton_Click(object sender, EventArgs e)
        {
            OpenCustomerSection();
        }

        private void ProductButton_Click(object sender, EventArgs e)
        {
            OpenProductSection();
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            OpenOrderSection();
        }

        private void UnloadReportButton_Click(object sender, EventArgs e)
        {
            OpenReportMaker();
        }

        private void ChangeUserButton_Click(object sender, EventArgs e)
        {
            ChangeUser();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Exit();
        }

       
    }
}
