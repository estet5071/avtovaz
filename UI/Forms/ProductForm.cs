using System;
using System.Drawing;
using System.Windows.Forms;
using Presentation.ViewInterfaces;

namespace UI.Forms
{
    internal partial class ProductForm : BaseSectionViewWithSecondGrid, IProductView
    {

        public ProductForm()
        {
            InitializeComponent();

            Load += Form_Load;
            addButton.Click += AddButton_Click;
            editButton.Click += EditButton_Click;
            removeButton.Click += RemoveButton_Click;
            productGrid.SelectionChanged += Grid_SelectionChanged;
            searchTextBox.TextChanged += SearchTextBox_TextChanged;
            toggle.Click += Toggle_Click;
            addPriceButton.Click += (object sender, EventArgs e) => SetNewPrice((string)productGrid.SelectedRows[0].Cells[0].Value);
            removePriceButton.Click += (object sender, EventArgs e) => RemovePrice((string)productGrid.SelectedRows[0].Cells[0].Value, (string)priceGrid.SelectedRows[0].Cells[0].Value, (string)priceGrid.SelectedRows[0].Cells[1].Value);
        }


        public event Action<string> SetNewPrice;
        public event Action<string, string, string> RemovePrice;

        public int CountOfRow { get => int.Parse(countLabel.Text); set => countLabel.Text = value.ToString(); }
        public decimal Price
        {
            get
            {
                if (decimal.TryParse(newPriceTextBox.Text, out decimal result) && result != 0 )
                {
                    return result;
                }
                throw new InvalidCastException("Введенная цена некорректна");
            }
        }
        
        public Size SizeOfMainGridWithSecond => new Size(1000, 305);
        public Size SizeOfMainGridWithoutSecond => new Size(1000, 476);
        public bool ToggleState => toggle.Checked;
        public string PriceError { set => errorPriceLabel.Text = value; }
        public string Descriprion { set => descriptionTextBox.Text = value; }
        public Image ProductPhoto { set => pictureBox.Image = value; }
        protected override DataGridView SecondGrid => priceGrid;
        protected override byte ComboBoxIndex => (byte) searchComboBox.SelectedIndex;
        protected override string SearchText => searchTextBox.Text;
        protected override DataGridView MainGrid => productGrid;


        public void ChangeSecondGridVisible(bool IsVisible)
        {
            if (IsVisible)
            {
                priceGrid.Show();
                priceLabel.Show();
                newPriceLabel.Show();
                newPriceTextBox.Show();
                errorPriceLabel.Show();
                priceLayoutPanel.Show();

                return;
            }

            priceGrid.Hide();
            priceLabel.Hide();
            newPriceLabel.Hide();
            newPriceTextBox.Hide();
            errorPriceLabel.Hide();
            priceLayoutPanel.Hide();
        }

    }
}
