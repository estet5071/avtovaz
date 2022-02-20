using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MetroFramework.Forms;
using Presentation.ViewInterfaces.Edit;

namespace UI.Forms.Edit
{
    public partial class ProductEditForm : MetroForm, IProductEditView
    {
        
        public ProductEditForm()
        {
            InitializeComponent();
            
        }

        public event Action Cancel;
        public event Action Apply;
        public event Action<int> CarModelChange;
        public event Action LoadPhoto;
        public event Action RemovePhoto;

        public Image Photo { set => pictureBox.Image = value; }
        public string Description { get => descriprionTextBox.Text; set => descriprionTextBox.Text = value; }
        public string CarModel { get => modelComboBox.Text; set => modelComboBox.Text = value; }
        public DateTime DateCreate { get => createDateTime.Value; set => createDateTime.Value = value; }
        public string CarKit { get => kitComboBox.Text; set => kitComboBox.Text = value; }
        public string CarBodys { get => carBodyComboBox.Text; set => carBodyComboBox.Text = value; }
        public string CarColor { get => colorComboBox.Text; set => colorComboBox.Text = value; }



        public void AddCarBodysToComboBox(List<string> carBodys)
        {
            carBodyComboBox.Items.Clear();
            carBodyComboBox.Items.AddRange(carBodys.ToArray());
        }

        public void AddCarColorsToComboBox(List<string> colors)
        {
            colorComboBox.Items.Clear();
            colorComboBox.Items.AddRange(colors.ToArray());
        }

        public void ShowError(string[] errors)
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
            pictureBox.Image = null;
            descriprionTextBox.Text = String.Empty;
            Show();
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            Apply();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void AddPhotoButton_Click(object sender, EventArgs e)
        {
            LoadPhoto();
        }

        private void RemovePhotoButton_Click(object sender, EventArgs e)
        {
            RemovePhoto();
        }

        private void ModelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarModelChange(modelComboBox.SelectedIndex);
        }
    }
}
