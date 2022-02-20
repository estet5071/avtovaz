using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MetroFramework.Forms;
using Presentation.ViewInterfaces.Edit;

namespace UI.Forms.Edit
{
    public partial class EmployeeEditForm : MetroForm, IEmployeeEditView
    {

        public EmployeeEditForm()
        {
            InitializeComponent();
        }


        public event Action Cancel;
        public event Action Apply;
        public event Action LoadPhoto;
        public event Action RemovePhoto;

        public Image Photo { set => pictureBox.Image = value; }
        public string Position { get => positionComboBox.Text; set => positionComboBox.Text = value; }
        public string FirstName { get => nameTextBox.Text; set => nameTextBox.Text = value; }
        public string LastName { get => lastNameTextBox.Text; set => lastNameTextBox.Text = value; }
        public string MiddleName { get => middleNameTextBox.Text;  set => middleNameTextBox.Text = value;  }
        public string Adress { get => adressTextBox.Text; set => adressTextBox.Text = value; }
        public string Phone { get => phoneTextBox.Text; set => phoneTextBox.Text = value; }
        public string Email { get => emailTextBox.Text; set => emailTextBox.Text = value; }
        public DateTime? Birthday { get 
            { 
                if(birthdayDateTime.Value.ToShortDateString() == DateTime.Now.ToShortDateString())
                    return null;
                return birthdayDateTime.Value;
            } 
            set => birthdayDateTime.Value = value == null? DateTime.Now : value.Value; }
        public string Login { get => loginTextBox.Text; set => loginTextBox.Text = value; }
        public string Password { get => passwordTextBox.Text; set => passwordTextBox.Text = value; }
        public string AccountAcces { get => accesComboBox.Text; set => accesComboBox.Text = value; }
        


        public void ShowForAdd()
        {
             
              Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Text = String.Empty);
              statusLabel.Text = String.Empty;
              phoneTextBox.Text = String.Empty;
              birthdayDateTime.Text = String.Empty;
              pictureBox.Image = null;
              accesComboBox.SelectedItem = null;

              Show();
        }


        public void FillComboBoxs(List<string> accessLevels, List<string> employeePositions)
        {
            positionComboBox.Items.Clear();
            accesComboBox.Items.Clear();
            positionComboBox.Items.AddRange(employeePositions.ToArray());
            accesComboBox.Items.AddRange(accessLevels.ToArray());
        }


        public void ShowError(string[] errors)
        {

            statusLabel.Text = string.Join(", ", errors);

        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            Apply?.Invoke();
        }



        private void CancelButton_Click(object sender, EventArgs e)
        {
            Cancel?.Invoke();
        }

       

        private void LoadPhotoButton_Click(object sender, EventArgs e)
        {

            LoadPhoto();

        }

        private void RemovePhotoButton_Click(object sender, EventArgs e)
        {
            RemovePhoto?.Invoke();
        }

        
    }
}
