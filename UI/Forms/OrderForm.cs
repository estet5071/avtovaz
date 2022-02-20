using System.Drawing;
using System.Windows.Forms;
using Presentation.ViewInterfaces;

namespace UI.Forms
{
    internal partial class OrderForm : BaseSectionViewWithSecondGrid, IOrderView
    {

        public OrderForm()
        {
            InitializeComponent();
            Load += Form_Load;
            addButton.Click += AddButton_Click;
            editButton.Click += EditButton_Click;
            removeButton.Click += RemoveButton_Click;
            orderGrid.SelectionChanged += Grid_SelectionChanged;
            searchTextBox.TextChanged += SearchTextBox_TextChanged;
            toggle.Click += Toggle_Click;
        }
        
        public Size SizeOfMainGridWithSecond => new Size(1212, 289);
        public Size SizeOfMainGridWithoutSecond => new Size(1212, 484);
        public bool ToggleState => toggle.Checked;
        public int CountOfRow { get => int.Parse(countLabel.Text); set => countLabel.Text = value.ToString(); }
        public decimal ProductSumm { set => sumLabel.Text = value.ToString(); }
        public string Error { set => errorLabel.Text = value; }
        protected override byte ComboBoxIndex => (byte)searchComboBox.SelectedIndex;
        protected override string SearchText => searchTextBox.Text;
        protected override DataGridView MainGrid => orderGrid;
        protected override DataGridView SecondGrid => itemsGrid;

        public void ChangeSecondGridVisible(bool IsVisible)
        {
            if (IsVisible)
            {
                itemsGrid.Show();
                productLabel.Show();
                sumLabel.Show();
                sumHelpLabel.Show();
                

            }
            else
            {
                itemsGrid.Hide();
                productLabel.Hide();
                sumLabel.Hide();
                sumHelpLabel.Hide();

            }
        }

    }
}


