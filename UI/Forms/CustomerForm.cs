using System.Windows.Forms;
using Presentation.ViewInterfaces;
using System.Drawing;

namespace UI.Forms
{
    internal partial class CustomerForm : BaseSectionViewWithSecondGrid, ISectionViewWithSecondGrid
    {
      
        public CustomerForm()
        {
            InitializeComponent();
            Load += Form_Load;
            addButton.Click += AddButton_Click;
            editButton.Click += EditButton_Click;
            deleteButton.Click += RemoveButton_Click;
            customerGrid.SelectionChanged += Grid_SelectionChanged;
            searchTextBox.TextChanged += SearchTextBox_TextChanged;
            toggle.Click += Toggle_Click;
        }

        public Size SizeOfMainGridWithSecond => new Size(1223, 284);
        public Size SizeOfMainGridWithoutSecond => new Size(1223, 472);
        public bool ToggleState => toggle.Checked;
        public int CountOfRow { get => int.Parse(countOfItemsLabel.Text); set => countOfItemsLabel.Text = value.ToString(); }

        protected override byte ComboBoxIndex => (byte)searchComboBox.SelectedIndex;
        protected override string SearchText => searchTextBox.Text;
        protected override DataGridView MainGrid => customerGrid;
        protected override DataGridView SecondGrid => orderGrid;

        public void ChangeSecondGridVisible(bool IsVisible)
        {
            if (IsVisible)
            {
                orderGrid.Show();
                ordersLabel.Show();

            }
            else
            {
                orderGrid.Hide();
                ordersLabel.Hide();
                
            }

        }

    }
}
