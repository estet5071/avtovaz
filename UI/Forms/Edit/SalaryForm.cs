using System;
using MetroFramework.Forms;
using Presentation.ViewInterfaces.Edit;

namespace UI.Forms.Edit
{
    public partial class SalaryForm : MetroForm, ISalaryEditView
    {
    
        public SalaryForm()
        {
            InitializeComponent();
       
        }

        public event Action Cancel;
        public event Action Apply;
        public event Action Calculate;

        public decimal DaySalary { get
            {
                if (decimal.TryParse(daySalaryTextBox.Text, out decimal result))
                {
                    return result;
                }
                throw new InvalidCastException("Дневной оклад некорректен");
            }
            set => daySalaryTextBox.Text = value.ToString(); }

        public double PrizeRatio { get
            {
                if (double.TryParse(prizeRatioTextBox.Text, out double result))
                {
                    return result;
                }
                throw new InvalidCastException("Коэффициент премии некорректен");
            }
            set => prizeRatioTextBox.Text = value.ToString();
        }


        public int WorkDays { get
            {
                if (int.TryParse(workDaysTextBox.Text, out int result))
                {
                    return result;
                }
                throw new InvalidCastException("Количество дней некорректно");
            }
            set => workDaysTextBox.Text = value.ToString();
        }

        public decimal TaxDeduction { get
            {
                if (decimal.TryParse(taxDeductionTextBox.Text, out decimal result))
                {
                    return result;
                }
                throw new InvalidCastException("Налоговый вычет некорректен");
            }
            set => taxDeductionTextBox.Text = value.ToString();
        }

        public decimal Tax { set => taxTextBox.Text = value.ToString(); }
        public decimal Result { set => resultTextBox.Text = value.ToString(); }
        public string Error { set => errorLabel.Text = value; }


        private void CalculateButton_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            Apply();
        }
    }
}
