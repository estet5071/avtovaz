using System;
using System.Linq;
using System.Windows.Forms;
using MetroFramework.Forms;
using Presentation.ViewInterfaces.Edit;

namespace UI.Forms.Edit
{
    public partial class OrderEditForm : MetroForm, IOrderEditView
    {
       
        public OrderEditForm()
        {
            InitializeComponent();
            
        }


        public event Action Apply;
        public event Action Cancel;
        public event Action AddProductToBasket;
        public event Action RemoveProductFromBasket;

        public bool OrderStatus { get => statusComboBox.SelectedIndex == 0; set => statusComboBox.SelectedIndex = true ? 0 : 1; }
        public DateTime DateCreate { get => createDateTime.Value; set => createDateTime.Value = value; }
        public string Client { get => customerBox.Text; set => customerBox.Text = value; }
        public string Employee { get => employeeComboBox.Text; set => employeeComboBox.Text = value; }
        public decimal OrderSum { get => decimal.Parse(sumLabel.Text); set => sumLabel.Text = value.ToString(); }


        public void AddCustomersToComboBox(string[] values)
        {
            customerBox.Items.AddRange(values);
        }

        public void AddEmployeesToComboBox(string[] values)
        {
            employeeComboBox.Items.AddRange(values);
        }

        public void ClearItemsOfComboBoxs()
        {
            employeeComboBox.Items.Clear();
            customerBox.Items.Clear();
        }


        public void ShowError(params string[] errors)
        {
            errorLabel.Text = String.Join(", ", errors);
        }

        public void ShowForAdd()
        {
            var comboboxs = Controls.OfType<ComboBox>().ToList();
            for (int i = 0; i < comboboxs.Count; i++)
            {
                comboboxs[i].SelectedItem = null;
            }

            createDateTime.Value = DateTime.Now;
            sumLabel.Text = "0";
            errorLabel.Text = String.Empty;

            Show();
        }


        public void AddToBasketGrid(params string[] values)
        {
            basketGrid.Rows.Add(values);
        }

        public void ClearBasketGrid()
        {
            basketGrid.Rows.Clear();
        }

        public void AddToProductsGrid(params string[] values)
        {
            productsGrid.Rows.Add(values);
        }

        public void ClearProductGrid()
        {
            productsGrid.Rows.Clear();
        }

        public int[] GetIdOfProductsInBasket()
        {
            int[] ProductsId = new int[basketGrid.Rows.Count];
            for (int i = 0; i < ProductsId.Length; i++)
            {
                ProductsId[i] = int.Parse(basketGrid.Rows[i].Cells[0].Value.ToString());
            }
            return ProductsId;
        }


        public string[] GetProductForAddToBasketGrid()
        {
            string [] values = new string[productsGrid.SelectedRows[0].Cells.Count];
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = productsGrid.SelectedRows[0].Cells[i].Value.ToString();
            }
            return values;
        }

       
        public int RemoveFromBasketGrid(out decimal productPrice)  
        {
            if(basketGrid.SelectedRows.Count == 0)
            {
                productPrice = 0;
                return 0;
            }
            productPrice = decimal.Parse(basketGrid.SelectedRows[0].Cells[6].Value.ToString());
            int id = int.Parse(basketGrid.SelectedRows[0].Cells[0].Value.ToString());
            basketGrid.Rows.RemoveAt(basketGrid.Rows.GetFirstRow(DataGridViewElementStates.Selected));
            return id;
        }


        private void AcceptButton_Click(object sender, EventArgs e)
        {
            Apply?.Invoke();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Cancel?.Invoke();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddProductToBasket?.Invoke();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            RemoveProductFromBasket?.Invoke();
        }

       
    }
}
