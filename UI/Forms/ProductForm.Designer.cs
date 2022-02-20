
namespace UI.Forms
{
    partial class ProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.productGrid = new MetroFramework.Controls.MetroGrid();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BodyType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.removeButton = new MetroFramework.Controls.MetroButton();
            this.editButton = new MetroFramework.Controls.MetroButton();
            this.addButton = new MetroFramework.Controls.MetroButton();
            this.priceGrid = new MetroFramework.Controls.MetroGrid();
            this.DateSet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.countLabel = new MetroFramework.Controls.MetroLabel();
            this.toggle = new MetroFramework.Controls.MetroToggle();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.priceLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.addPriceButton = new MetroFramework.Controls.MetroButton();
            this.removePriceButton = new MetroFramework.Controls.MetroButton();
            this.newPriceLabel = new MetroFramework.Controls.MetroLabel();
            this.searchLabel = new MetroFramework.Controls.MetroLabel();
            this.searchLabel1 = new MetroFramework.Controls.MetroLabel();
            this.searchComboBox = new MetroFramework.Controls.MetroComboBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.newPriceTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.errorPriceLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.productGrid)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.priceLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // productGrid
            // 
            this.productGrid.AllowUserToAddRows = false;
            this.productGrid.AllowUserToDeleteRows = false;
            this.productGrid.AllowUserToResizeRows = false;
            this.productGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.productGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.productGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.productGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Model,
            this.BodyType,
            this.color,
            this.kit,
            this.Year});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.productGrid.EnableHeadersVisualStyles = false;
            this.productGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.productGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.productGrid.Location = new System.Drawing.Point(10, 73);
            this.productGrid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.productGrid.Name = "productGrid";
            this.productGrid.ReadOnly = true;
            this.productGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.productGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.productGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productGrid.Size = new System.Drawing.Size(1000, 305);
            this.productGrid.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Model
            // 
            this.Model.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Model.HeaderText = "Модель";
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            // 
            // BodyType
            // 
            this.BodyType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BodyType.HeaderText = "Кузов";
            this.BodyType.Name = "BodyType";
            this.BodyType.ReadOnly = true;
            // 
            // color
            // 
            this.color.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.color.HeaderText = "Цвет";
            this.color.Name = "color";
            this.color.ReadOnly = true;
            // 
            // kit
            // 
            this.kit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kit.HeaderText = "Комплектация";
            this.kit.Name = "kit";
            this.kit.ReadOnly = true;
            // 
            // Year
            // 
            this.Year.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Year.HeaderText = "Дата изготовления";
            this.Year.Name = "Year";
            this.Year.ReadOnly = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.removeButton);
            this.flowLayoutPanel1.Controls.Add(this.editButton);
            this.flowLayoutPanel1.Controls.Add(this.addButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(895, 555);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(305, 49);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(4, 3);
            this.removeButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(88, 40);
            this.removeButton.TabIndex = 0;
            this.removeButton.Text = "Удалить";
            this.removeButton.UseSelectable = true;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(100, 3);
            this.editButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(103, 40);
            this.editButton.TabIndex = 1;
            this.editButton.Text = "Редактировать";
            this.editButton.UseSelectable = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(211, 3);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(88, 40);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Добавить";
            this.addButton.UseSelectable = true;
            // 
            // priceGrid
            // 
            this.priceGrid.AllowUserToAddRows = false;
            this.priceGrid.AllowUserToDeleteRows = false;
            this.priceGrid.AllowUserToResizeRows = false;
            this.priceGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.priceGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.priceGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.priceGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.priceGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.priceGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.priceGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateSet,
            this.Value});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.priceGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.priceGrid.EnableHeadersVisualStyles = false;
            this.priceGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.priceGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.priceGrid.Location = new System.Drawing.Point(22, 430);
            this.priceGrid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.priceGrid.Name = "priceGrid";
            this.priceGrid.ReadOnly = true;
            this.priceGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.priceGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.priceGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.priceGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.priceGrid.Size = new System.Drawing.Size(838, 170);
            this.priceGrid.TabIndex = 4;
            // 
            // DateSet
            // 
            this.DateSet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateSet.HeaderText = "Дата установки";
            this.DateSet.Name = "DateSet";
            this.DateSet.ReadOnly = true;
            // 
            // Value
            // 
            this.Value.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Value.HeaderText = "Значение";
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(40, 397);
            this.priceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(88, 19);
            this.priceLabel.TabIndex = 5;
            this.priceLabel.Text = "История цен";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(273, 31);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(82, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Количество:";
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Location = new System.Drawing.Point(362, 31);
            this.countLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(16, 19);
            this.countLabel.TabIndex = 7;
            this.countLabel.Text = "0";
            // 
            // toggle
            // 
            this.toggle.AutoSize = true;
            this.toggle.Checked = true;
            this.toggle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toggle.DisplayStatus = false;
            this.toggle.Location = new System.Drawing.Point(66, 37);
            this.toggle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.toggle.Name = "toggle";
            this.toggle.Size = new System.Drawing.Size(50, 19);
            this.toggle.TabIndex = 8;
            this.toggle.Text = "On";
            this.toggle.UseSelectable = true;
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(1035, 305);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(205, 244);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 9;
            this.pictureBox.TabStop = false;
            // 
            // priceLayoutPanel
            // 
            this.priceLayoutPanel.AutoSize = true;
            this.priceLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.priceLayoutPanel.Controls.Add(this.addPriceButton);
            this.priceLayoutPanel.Controls.Add(this.removePriceButton);
            this.priceLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.priceLayoutPanel.Location = new System.Drawing.Point(895, 469);
            this.priceLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.priceLayoutPanel.Name = "priceLayoutPanel";
            this.priceLayoutPanel.Size = new System.Drawing.Size(115, 87);
            this.priceLayoutPanel.TabIndex = 10;
            // 
            // addPriceButton
            // 
            this.addPriceButton.AutoSize = true;
            this.addPriceButton.Location = new System.Drawing.Point(4, 3);
            this.addPriceButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addPriceButton.Name = "addPriceButton";
            this.addPriceButton.Size = new System.Drawing.Size(105, 46);
            this.addPriceButton.TabIndex = 0;
            this.addPriceButton.Text = "Установить \r\nновую цену";
            this.addPriceButton.UseSelectable = true;
            // 
            // removePriceButton
            // 
            this.removePriceButton.Location = new System.Drawing.Point(4, 55);
            this.removePriceButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.removePriceButton.Name = "removePriceButton";
            this.removePriceButton.Size = new System.Drawing.Size(105, 27);
            this.removePriceButton.TabIndex = 1;
            this.removePriceButton.Text = "Удалить цену";
            this.removePriceButton.UseSelectable = true;
            // 
            // newPriceLabel
            // 
            this.newPriceLabel.AutoSize = true;
            this.newPriceLabel.Location = new System.Drawing.Point(217, 397);
            this.newPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.newPriceLabel.Name = "newPriceLabel";
            this.newPriceLabel.Size = new System.Drawing.Size(84, 19);
            this.newPriceLabel.TabIndex = 12;
            this.newPriceLabel.Text = "Новая цена:";
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(755, 32);
            this.searchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(46, 19);
            this.searchLabel.TabIndex = 14;
            this.searchLabel.Text = "Поиск";
            // 
            // searchLabel1
            // 
            this.searchLabel1.AutoSize = true;
            this.searchLabel1.Location = new System.Drawing.Point(995, 32);
            this.searchLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchLabel1.Name = "searchLabel1";
            this.searchLabel1.Size = new System.Drawing.Size(26, 19);
            this.searchLabel1.TabIndex = 15;
            this.searchLabel1.Text = "По";
            // 
            // searchComboBox
            // 
            this.searchComboBox.FormattingEnabled = true;
            this.searchComboBox.ItemHeight = 23;
            this.searchComboBox.Items.AddRange(new object[] {
            "ID",
            "Модель",
            "Кузов",
            "Цвет",
            "Комплектация",
            "Дата изготовления"});
            this.searchComboBox.Location = new System.Drawing.Point(1035, 25);
            this.searchComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.searchComboBox.Name = "searchComboBox";
            this.searchComboBox.Size = new System.Drawing.Size(205, 29);
            this.searchComboBox.TabIndex = 16;
            this.searchComboBox.UseSelectable = true;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(808, 31);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(180, 23);
            this.searchTextBox.TabIndex = 17;
            // 
            // newPriceTextBox
            // 
            this.newPriceTextBox.Location = new System.Drawing.Point(308, 397);
            this.newPriceTextBox.Name = "newPriceTextBox";
            this.newPriceTextBox.Size = new System.Drawing.Size(157, 23);
            this.newPriceTextBox.TabIndex = 18;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(1035, 88);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(205, 211);
            this.descriptionTextBox.TabIndex = 19;
            this.descriptionTextBox.Text = "";
            // 
            // errorPriceLabel
            // 
            this.errorPriceLabel.AutoSize = true;
            this.errorPriceLabel.Location = new System.Drawing.Point(471, 397);
            this.errorPriceLabel.Name = "errorPriceLabel";
            this.errorPriceLabel.Size = new System.Drawing.Size(0, 0);
            this.errorPriceLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.errorPriceLabel.TabIndex = 20;
            this.errorPriceLabel.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(10, 37);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(43, 19);
            this.metroLabel1.TabIndex = 21;
            this.metroLabel1.Text = "Цены";
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 613);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.errorPriceLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.newPriceTextBox);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchComboBox);
            this.Controls.Add(this.searchLabel1);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.newPriceLabel);
            this.Controls.Add(this.priceLayoutPanel);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.toggle);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.priceGrid);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.productGrid);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1266, 613);
            this.MinimumSize = new System.Drawing.Size(1266, 613);
            this.Name = "ProductForm";
            this.Padding = new System.Windows.Forms.Padding(23, 69, 23, 23);
            this.Text = "Продукты компании";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            ((System.ComponentModel.ISupportInitialize)(this.productGrid)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.priceGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.priceLayoutPanel.ResumeLayout(false);
            this.priceLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid productGrid;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroButton removeButton;
        private MetroFramework.Controls.MetroButton editButton;
        private MetroFramework.Controls.MetroButton addButton;
        private MetroFramework.Controls.MetroGrid priceGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private MetroFramework.Controls.MetroLabel priceLabel;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel countLabel;
        private MetroFramework.Controls.MetroToggle toggle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn BodyType;
        private System.Windows.Forms.DataGridViewTextBoxColumn color;
        private System.Windows.Forms.DataGridViewTextBoxColumn kit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.FlowLayoutPanel priceLayoutPanel;
        private MetroFramework.Controls.MetroButton addPriceButton;
        private MetroFramework.Controls.MetroButton removePriceButton;
        private MetroFramework.Controls.MetroLabel newPriceLabel;
        private MetroFramework.Controls.MetroLabel searchLabel;
        private MetroFramework.Controls.MetroLabel searchLabel1;
        private MetroFramework.Controls.MetroComboBox searchComboBox;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.TextBox newPriceTextBox;
        private System.Windows.Forms.RichTextBox descriptionTextBox;
        private MetroFramework.Controls.MetroLabel errorPriceLabel;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}