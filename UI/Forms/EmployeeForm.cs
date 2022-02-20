using System;
using System.Drawing;
using System.Windows.Forms;
using Presentation.ViewInterfaces;


namespace UI.Forms
{
    internal partial class EmployeeForm : BaseSectionView, IEmployeeView
    {
       

        public EmployeeForm()
        {
            InitializeComponent();
            Load += Form_Load;
            addButton.Click += AddButton_Click;
            editButton.Click += EditButton_Click;
            removeButton.Click += RemoveButton_Click;
            grid.SelectionChanged += Grid_SelectionChanged;
            searchTextBox.TextChanged += SearchTextBox_TextChanged;
        }

        public event Action<string> SalaryButtonClick;

        public Image EmployeePhoto { set => empPhoto.Image = value; }
        public int CountOfRow { get => int.Parse(countLabel.Text); set => countLabel.Text = value.ToString(); }
        protected override byte ComboBoxIndex => (byte)searchComboBox.SelectedIndex;
        protected override string SearchText => searchTextBox.Text;
        protected override DataGridView MainGrid => grid;

       
        

        private void SalaryButton_Click(object sender, System.EventArgs e)
        {
            if (grid.SelectedRows.Count == 0)
                return;
            SalaryButtonClick?.Invoke(grid.SelectedRows[0].Cells[0].Value.ToString());

        }
    }
}
