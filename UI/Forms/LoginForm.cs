using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using Presentation.ViewInterfaces;

namespace UI.Forms
{
    public partial class LoginForm : MetroForm, ILoginView
    {
        private readonly ApplicationContext _context;

        public LoginForm(ApplicationContext context)
        {
            InitializeComponent();
            _context = context;
        }

       public event Action Login;

       public string UserName { get => loginTextBox.Text;}
       public string Password { get => passwordTextBox.Text; }


        public void UpdateControls(string userName, string password, string errorMessage)
        {
            loginTextBox.Text = userName;
            passwordTextBox.Text = password;
            statusLabel.Text = errorMessage;
        }



       public void ShowMessage(string message)
        {
           
            try 
            {
                MetroMessageBox.Show(this, message, "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information, 200);
            }
            catch (Exception) { }
        }


        public new void Show()
        {
            if (_context.MainForm == null)
            {
                _context.MainForm = this;
                Application.Run(_context);
                return;
            }

            _context.MainForm = this;
            base.Show();
            
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            Login?.Invoke();

        }


    }
}
