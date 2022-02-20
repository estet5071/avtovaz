using System;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using Presentation.ViewInterfaces;

namespace UI.Forms
{
    public partial class ReportForm : MetroForm, IReportView
    {
        

        public ReportForm()
        {
            InitializeComponent();
        }

        public event Action<byte> ChangeReportType;
        public event Action ChoosePath;
        public event Action UploadReport;

        public string Path { set => pathTextBox.Text = value; }

        public string Error { set => errorLabel.Text = value; }

        public DateTime StartDateTime => startDateTime.Value;

        public DateTime EndDateTime => endDateTime.Value;

        public bool StartDateTimeEnabled => startDateTime.Enabled;

        public bool EndDateTimeEnabled => endDateTime.Enabled;


        public void ShowNotice(bool isError)
        {
            try
            {
                if (!isError)
                    MetroMessageBox.Show(this, "Отчет успешно сформирован", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);

                else
                    MetroMessageBox.Show(this, "Не удалось сформировать отчет", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            catch (Exception) { }

        }

        private void SomeRadioButton_Click(object sender, EventArgs e)
        {
            ChangeReportType(byte.Parse((sender as RadioButton).Tag.ToString()));
        }

        private void PathButton_Click(object sender, EventArgs e)
        {
            ChoosePath();
        }

        private void StartDateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
          startDateTime.Enabled =  startDateCheckBox.Checked;
        }


        private void EndDateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            endDateTime.Enabled = endDateCheckBox.Checked;
        }


        private void UploadButton_Click(object sender, EventArgs e)
        {

            UploadReport();
        }

       
    }
}
