
namespace UI.Forms
{
    partial class OrderForm
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
            this.orderGrid = new MetroFramework.Controls.MetroGrid();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateCrrate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateClose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemsGrid = new MetroFramework.Controls.MetroGrid();
            this.ID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bodyType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.removeButton = new MetroFramework.Controls.MetroButton();
            this.editButton = new MetroFramework.Controls.MetroButton();
            this.addButton = new MetroFramework.Controls.MetroButton();
            this.productLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel = new MetroFramework.Controls.MetroLabel();
            this.countLabel = new MetroFramework.Controls.MetroLabel();
            this.searchLabel = new MetroFramework.Controls.MetroLabel();
            this.searchLabel1 = new MetroFramework.Controls.MetroLabel();
            this.searchComboBox = new MetroFramework.Controls.MetroComboBox();
            this.sumLabel = new MetroFramework.Controls.MetroLabel();
            this.sumHelpLabel = new MetroFramework.Controls.MetroLabel();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.toggle = new MetroFramework.Controls.MetroToggle();
            this.toggleLabel = new MetroFramework.Controls.MetroLabel();
            this.errorLabel = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.orderGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsGrid)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderGrid
            // 
            this.orderGrid.AllowUserToAddRows = false;
            this.orderGrid.AllowUserToDeleteRows = false;
            this.orderGrid.AllowUserToResizeRows = false;
            this.orderGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.orderGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.orderGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.orderGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orderGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.orderGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Employee,
            this.Client,
            this.DateCrrate,
            this.DateClose,
            this.Count,
            this.status});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.orderGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.orderGrid.EnableHeadersVisualStyles = false;
            this.orderGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.orderGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.orderGrid.Location = new System.Drawing.Point(27, 73);
            this.orderGrid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.orderGrid.Name = "orderGrid";
            this.orderGrid.ReadOnly = true;
            this.orderGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orderGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.orderGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.orderGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.orderGrid.Size = new System.Drawing.Size(1212, 289);
            this.orderGrid.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.HeaderText = "Номер";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Employee
            // 
            this.Employee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Employee.HeaderText = "Сотрудник";
            this.Employee.Name = "Employee";
            this.Employee.ReadOnly = true;
            // 
            // Client
            // 
            this.Client.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Client.HeaderText = "Клиент";
            this.Client.Name = "Client";
            this.Client.ReadOnly = true;
            // 
            // DateCrrate
            // 
            this.DateCrrate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateCrrate.HeaderText = "Дата создания";
            this.DateCrrate.Name = "DateCrrate";
            this.DateCrrate.ReadOnly = true;
            // 
            // DateClose
            // 
            this.DateClose.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateClose.HeaderText = "Дата закрытия";
            this.DateClose.Name = "DateClose";
            this.DateClose.ReadOnly = true;
            // 
            // Count
            // 
            this.Count.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Count.HeaderText = "Количество позиций";
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            // 
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.status.HeaderText = "Статус";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // itemsGrid
            // 
            this.itemsGrid.AllowUserToAddRows = false;
            this.itemsGrid.AllowUserToDeleteRows = false;
            this.itemsGrid.AllowUserToResizeRows = false;
            this.itemsGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.itemsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.itemsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.itemsGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.itemsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.itemsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID1,
            this.Model,
            this.bodyType,
            this.color,
            this.kit,
            this.date,
            this.Value});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.itemsGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.itemsGrid.EnableHeadersVisualStyles = false;
            this.itemsGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.itemsGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.itemsGrid.Location = new System.Drawing.Point(27, 397);
            this.itemsGrid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.itemsGrid.Name = "itemsGrid";
            this.itemsGrid.ReadOnly = true;
            this.itemsGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.itemsGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.itemsGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.itemsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.itemsGrid.Size = new System.Drawing.Size(904, 200);
            this.itemsGrid.TabIndex = 1;
            // 
            // ID1
            // 
            this.ID1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ID1.HeaderText = "ID";
            this.ID1.Name = "ID1";
            this.ID1.ReadOnly = true;
            this.ID1.Width = 41;
            // 
            // Model
            // 
            this.Model.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Model.HeaderText = "Модель";
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            // 
            // bodyType
            // 
            this.bodyType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bodyType.HeaderText = "Кузов";
            this.bodyType.Name = "bodyType";
            this.bodyType.ReadOnly = true;
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
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.date.HeaderText = "Дата выпуска";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // Value
            // 
            this.Value.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Value.HeaderText = "Стоимость";
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.removeButton);
            this.flowLayoutPanel1.Controls.Add(this.editButton);
            this.flowLayoutPanel1.Controls.Add(this.addButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(943, 563);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(296, 34);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(4, 3);
            this.removeButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(88, 27);
            this.removeButton.TabIndex = 0;
            this.removeButton.Text = "Удалить";
            this.removeButton.UseSelectable = true;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(100, 3);
            this.editButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(88, 27);
            this.editButton.TabIndex = 1;
            this.editButton.Text = "Редактировать";
            this.editButton.UseSelectable = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(196, 3);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(88, 27);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Добавить";
            this.addButton.UseSelectable = true;
            // 
            // productLabel
            // 
            this.productLabel.AutoSize = true;
            this.productLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.productLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.productLabel.Location = new System.Drawing.Point(27, 365);
            this.productLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(95, 25);
            this.productLabel.TabIndex = 3;
            this.productLabel.Text = "Продукты";
            // 
            // metroLabel
            // 
            this.metroLabel.AutoSize = true;
            this.metroLabel.Location = new System.Drawing.Point(295, 35);
            this.metroLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel.Name = "metroLabel";
            this.metroLabel.Size = new System.Drawing.Size(82, 19);
            this.metroLabel.TabIndex = 4;
            this.metroLabel.Text = "Количество:";
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Location = new System.Drawing.Point(388, 35);
            this.countLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(16, 19);
            this.countLabel.TabIndex = 5;
            this.countLabel.Text = "0";
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(679, 35);
            this.searchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(46, 19);
            this.searchLabel.TabIndex = 6;
            this.searchLabel.Text = "Поиск";
            // 
            // searchLabel1
            // 
            this.searchLabel1.AutoSize = true;
            this.searchLabel1.Location = new System.Drawing.Point(1001, 35);
            this.searchLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchLabel1.Name = "searchLabel1";
            this.searchLabel1.Size = new System.Drawing.Size(26, 19);
            this.searchLabel1.TabIndex = 7;
            this.searchLabel1.Text = "По";
            // 
            // searchComboBox
            // 
            this.searchComboBox.FormattingEnabled = true;
            this.searchComboBox.ItemHeight = 23;
            this.searchComboBox.Items.AddRange(new object[] {
            "Номер",
            "Сотрудник",
            "Клиент",
            "Дата создания",
            "Дата закрытия",
            "Количество позиций",
            "Статус"});
            this.searchComboBox.Location = new System.Drawing.Point(1044, 29);
            this.searchComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.searchComboBox.Name = "searchComboBox";
            this.searchComboBox.Size = new System.Drawing.Size(195, 29);
            this.searchComboBox.TabIndex = 8;
            this.searchComboBox.UseSelectable = true;
            // 
            // sumLabel
            // 
            this.sumLabel.AutoSize = true;
            this.sumLabel.Location = new System.Drawing.Point(715, 372);
            this.sumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sumLabel.Name = "sumLabel";
            this.sumLabel.Size = new System.Drawing.Size(0, 0);
            this.sumLabel.Style = MetroFramework.MetroColorStyle.Green;
            this.sumLabel.TabIndex = 10;
            this.sumLabel.UseStyleColors = true;
            // 
            // sumHelpLabel
            // 
            this.sumHelpLabel.AutoSize = true;
            this.sumHelpLabel.Location = new System.Drawing.Point(659, 372);
            this.sumHelpLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sumHelpLabel.Name = "sumHelpLabel";
            this.sumHelpLabel.Size = new System.Drawing.Size(52, 19);
            this.sumHelpLabel.TabIndex = 11;
            this.sumHelpLabel.Text = "Сумма:";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(732, 35);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(253, 23);
            this.searchTextBox.TabIndex = 12;
            // 
            // toggle
            // 
            this.toggle.AutoSize = true;
            this.toggle.Checked = true;
            this.toggle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toggle.DisplayStatus = false;
            this.toggle.Location = new System.Drawing.Point(112, 35);
            this.toggle.Name = "toggle";
            this.toggle.Size = new System.Drawing.Size(50, 19);
            this.toggle.TabIndex = 13;
            this.toggle.Text = "On";
            this.toggle.UseSelectable = true;
            // 
            // toggleLabel
            // 
            this.toggleLabel.AutoSize = true;
            this.toggleLabel.Location = new System.Drawing.Point(27, 35);
            this.toggleLabel.Name = "toggleLabel";
            this.toggleLabel.Size = new System.Drawing.Size(67, 19);
            this.toggleLabel.TabIndex = 14;
            this.toggleLabel.Text = "Продукты";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(943, 527);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 0);
            this.errorLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.errorLabel.TabIndex = 15;
            this.errorLabel.UseStyleColors = true;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 613);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.toggleLabel);
            this.Controls.Add(this.toggle);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.sumHelpLabel);
            this.Controls.Add(this.sumLabel);
            this.Controls.Add(this.searchComboBox);
            this.Controls.Add(this.searchLabel1);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.metroLabel);
            this.Controls.Add(this.productLabel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.itemsGrid);
            this.Controls.Add(this.orderGrid);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1266, 613);
            this.MinimumSize = new System.Drawing.Size(1266, 613);
            this.Name = "OrderForm";
            this.Padding = new System.Windows.Forms.Padding(23, 69, 23, 23);
            this.Text = "Заказы";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            ((System.ComponentModel.ISupportInitialize)(this.orderGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsGrid)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid orderGrid;
        private MetroFramework.Controls.MetroGrid itemsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn bodyType;
        private System.Windows.Forms.DataGridViewTextBoxColumn color;
        private System.Windows.Forms.DataGridViewTextBoxColumn kit;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroButton removeButton;
        private MetroFramework.Controls.MetroButton editButton;
        private MetroFramework.Controls.MetroButton addButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateCrrate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private MetroFramework.Controls.MetroLabel productLabel;
        private MetroFramework.Controls.MetroLabel metroLabel;
        private MetroFramework.Controls.MetroLabel countLabel;
        private MetroFramework.Controls.MetroLabel searchLabel;
        private MetroFramework.Controls.MetroLabel searchLabel1;
        private MetroFramework.Controls.MetroComboBox searchComboBox;
        private MetroFramework.Controls.MetroLabel sumLabel;
        private MetroFramework.Controls.MetroLabel sumHelpLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private MetroFramework.Controls.MetroToggle toggle;
        private MetroFramework.Controls.MetroLabel toggleLabel;
        private MetroFramework.Controls.MetroLabel errorLabel;
    }
}