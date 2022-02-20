using System;
using System.Linq;
using System.Windows.Forms;
using MetroFramework.Forms;
using Presentation.ViewInterfaces.Edit;

namespace UI.Forms.Edit
{
    public partial class CustomerEditForm : MetroForm, ICustomerEditView
    {

        public CustomerEditForm()
        {
            InitializeComponent();
        }

        public event Action Cancel;
        public event Action Apply;

        public new string Name { get => nameTextBox.Text; set => nameTextBox.Text = value; }
        public string Phone { get => phoneTextBox.Text; set => phoneTextBox.Text = value; }
        public string Email { get => emailTextBox.Text; set => emailTextBox.Text = value; }
        public string Address { get => addressTextBox.Text; set => addressTextBox.Text = value; }


        public void ShowError(string[] errors)
        {
            errorLabel.Text = String.Join(", ", errors);
        }

        public void ShowForAdd()
        {
            Controls.OfType<TextBox>().ToList().ForEach(t => t.Text = string.Empty);
            phoneTextBox.Text = string.Empty;
            errorLabel.Text = string.Empty;
            Show();
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
