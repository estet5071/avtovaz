
namespace UI.Forms.Edit
{
    partial class ProductEditForm
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
            this.descriprionTextBox = new System.Windows.Forms.RichTextBox();
            this.createDateTime = new MetroFramework.Controls.MetroDateTime();
            this.modelLabel = new MetroFramework.Controls.MetroLabel();
            this.bodyTypeLabel = new MetroFramework.Controls.MetroLabel();
            this.colorLabel = new MetroFramework.Controls.MetroLabel();
            this.kitLabel = new MetroFramework.Controls.MetroLabel();
            this.discriprionLabel = new MetroFramework.Controls.MetroLabel();
            this.yearLabel = new MetroFramework.Controls.MetroLabel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.photoLabel = new MetroFramework.Controls.MetroLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cancelButton = new MetroFramework.Controls.MetroButton();
            this.acceptButton = new MetroFramework.Controls.MetroButton();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.removePhotoButton = new MetroFramework.Controls.MetroButton();
            this.addPhotoButton = new MetroFramework.Controls.MetroButton();
            this.fieldLabel = new MetroFramework.Controls.MetroLabel();
            this.kitComboBox = new MetroFramework.Controls.MetroComboBox();
            this.modelComboBox = new MetroFramework.Controls.MetroComboBox();
            this.carBodyComboBox = new MetroFramework.Controls.MetroComboBox();
            this.colorComboBox = new MetroFramework.Controls.MetroComboBox();
            this.errorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // descriprionTextBox
            // 
            this.descriprionTextBox.Location = new System.Drawing.Point(597, 113);
            this.descriprionTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.descriprionTextBox.Name = "descriprionTextBox";
            this.descriprionTextBox.Size = new System.Drawing.Size(212, 265);
            this.descriprionTextBox.TabIndex = 4;
            this.descriprionTextBox.Text = "";
            // 
            // createDateTime
            // 
            this.createDateTime.Location = new System.Drawing.Point(405, 264);
            this.createDateTime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.createDateTime.MinimumSize = new System.Drawing.Size(0, 29);
            this.createDateTime.Name = "createDateTime";
            this.createDateTime.Size = new System.Drawing.Size(145, 29);
            this.createDateTime.TabIndex = 5;
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Location = new System.Drawing.Point(29, 113);
            this.modelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(62, 19);
            this.modelLabel.TabIndex = 6;
            this.modelLabel.Text = "Модель*";
            // 
            // bodyTypeLabel
            // 
            this.bodyTypeLabel.AutoSize = true;
            this.bodyTypeLabel.Location = new System.Drawing.Point(42, 181);
            this.bodyTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bodyTypeLabel.Name = "bodyTypeLabel";
            this.bodyTypeLabel.Size = new System.Drawing.Size(49, 19);
            this.bodyTypeLabel.TabIndex = 7;
            this.bodyTypeLabel.Text = "Кузов*";
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Location = new System.Drawing.Point(354, 119);
            this.colorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(44, 19);
            this.colorLabel.TabIndex = 8;
            this.colorLabel.Text = "Цвет*";
            // 
            // kitLabel
            // 
            this.kitLabel.AutoSize = true;
            this.kitLabel.Location = new System.Drawing.Point(296, 181);
            this.kitLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kitLabel.Name = "kitLabel";
            this.kitLabel.Size = new System.Drawing.Size(102, 19);
            this.kitLabel.TabIndex = 9;
            this.kitLabel.Text = "Комплектация*";
            // 
            // discriprionLabel
            // 
            this.discriprionLabel.AutoSize = true;
            this.discriprionLabel.Location = new System.Drawing.Point(665, 88);
            this.discriprionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.discriprionLabel.Name = "discriprionLabel";
            this.discriprionLabel.Size = new System.Drawing.Size(72, 19);
            this.discriprionLabel.TabIndex = 10;
            this.discriprionLabel.Text = "Описание";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(405, 239);
            this.yearLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(131, 19);
            this.yearLabel.TabIndex = 11;
            this.yearLabel.Text = "Дата изготовления*";
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(27, 238);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(200, 236);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 12;
            this.pictureBox.TabStop = false;
            // 
            // photoLabel
            // 
            this.photoLabel.AutoSize = true;
            this.photoLabel.Location = new System.Drawing.Point(102, 212);
            this.photoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.photoLabel.Name = "photoLabel";
            this.photoLabel.Size = new System.Drawing.Size(40, 19);
            this.photoLabel.TabIndex = 13;
            this.photoLabel.Text = "Фото";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.cancelButton);
            this.flowLayoutPanel1.Controls.Add(this.acceptButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(576, 440);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(210, 35);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(4, 3);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(88, 27);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Отменить";
            this.cancelButton.UseSelectable = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(100, 3);
            this.acceptButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(104, 27);
            this.acceptButton.TabIndex = 1;
            this.acceptButton.Text = "Подтвердить";
            this.acceptButton.UseSelectable = true;
            this.acceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel2.Controls.Add(this.removePhotoButton);
            this.flowLayoutPanel2.Controls.Add(this.addPhotoButton);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(237, 440);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(195, 34);
            this.flowLayoutPanel2.TabIndex = 15;
            // 
            // removePhotoButton
            // 
            this.removePhotoButton.Location = new System.Drawing.Point(4, 3);
            this.removePhotoButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.removePhotoButton.Name = "removePhotoButton";
            this.removePhotoButton.Size = new System.Drawing.Size(88, 27);
            this.removePhotoButton.TabIndex = 0;
            this.removePhotoButton.Text = "Удалить";
            this.removePhotoButton.UseSelectable = true;
            this.removePhotoButton.Click += new System.EventHandler(this.RemovePhotoButton_Click);
            // 
            // addPhotoButton
            // 
            this.addPhotoButton.Location = new System.Drawing.Point(100, 3);
            this.addPhotoButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addPhotoButton.Name = "addPhotoButton";
            this.addPhotoButton.Size = new System.Drawing.Size(88, 27);
            this.addPhotoButton.TabIndex = 1;
            this.addPhotoButton.Text = "Загрузить";
            this.addPhotoButton.UseSelectable = true;
            this.addPhotoButton.Click += new System.EventHandler(this.AddPhotoButton_Click);
            // 
            // fieldLabel
            // 
            this.fieldLabel.AutoSize = true;
            this.fieldLabel.Location = new System.Drawing.Point(27, 69);
            this.fieldLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fieldLabel.Name = "fieldLabel";
            this.fieldLabel.Size = new System.Drawing.Size(148, 19);
            this.fieldLabel.TabIndex = 16;
            this.fieldLabel.Text = "* - обязательные поля";
            // 
            // kitComboBox
            // 
            this.kitComboBox.FormattingEnabled = true;
            this.kitComboBox.ItemHeight = 23;
            this.kitComboBox.Items.AddRange(new object[] {
            "Classic",
            "Comfort",
            "Comfort Light",
            "Luxe"});
            this.kitComboBox.Location = new System.Drawing.Point(405, 181);
            this.kitComboBox.Name = "kitComboBox";
            this.kitComboBox.Size = new System.Drawing.Size(157, 29);
            this.kitComboBox.TabIndex = 21;
            this.kitComboBox.UseSelectable = true;
            // 
            // modelComboBox
            // 
            this.modelComboBox.FormattingEnabled = true;
            this.modelComboBox.ItemHeight = 23;
            this.modelComboBox.Items.AddRange(new object[] {
            "Granta",
            "Vesta"});
            this.modelComboBox.Location = new System.Drawing.Point(98, 113);
            this.modelComboBox.Name = "modelComboBox";
            this.modelComboBox.Size = new System.Drawing.Size(181, 29);
            this.modelComboBox.TabIndex = 22;
            this.modelComboBox.UseSelectable = true;
            this.modelComboBox.SelectedIndexChanged += new System.EventHandler(this.ModelComboBox_SelectedIndexChanged);
            // 
            // carBodyComboBox
            // 
            this.carBodyComboBox.FormattingEnabled = true;
            this.carBodyComboBox.ItemHeight = 23;
            this.carBodyComboBox.Location = new System.Drawing.Point(98, 180);
            this.carBodyComboBox.Name = "carBodyComboBox";
            this.carBodyComboBox.Size = new System.Drawing.Size(181, 29);
            this.carBodyComboBox.TabIndex = 23;
            this.carBodyComboBox.UseSelectable = true;
            // 
            // colorComboBox
            // 
            this.colorComboBox.FormattingEnabled = true;
            this.colorComboBox.ItemHeight = 23;
            this.colorComboBox.Location = new System.Drawing.Point(405, 113);
            this.colorComboBox.Name = "colorComboBox";
            this.colorComboBox.Size = new System.Drawing.Size(157, 29);
            this.colorComboBox.TabIndex = 24;
            this.colorComboBox.UseSelectable = true;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(188, 58);
            this.errorLabel.MaximumSize = new System.Drawing.Size(600, 0);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 15);
            this.errorLabel.TabIndex = 25;
            // 
            // ProductEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 493);
            this.ControlBox = false;
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.colorComboBox);
            this.Controls.Add(this.carBodyComboBox);
            this.Controls.Add(this.modelComboBox);
            this.Controls.Add(this.kitComboBox);
            this.Controls.Add(this.fieldLabel);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.photoLabel);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.discriprionLabel);
            this.Controls.Add(this.kitLabel);
            this.Controls.Add(this.colorLabel);
            this.Controls.Add(this.bodyTypeLabel);
            this.Controls.Add(this.modelLabel);
            this.Controls.Add(this.createDateTime);
            this.Controls.Add(this.descriprionTextBox);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ProductEditForm";
            this.Padding = new System.Windows.Forms.Padding(23, 69, 23, 23);
            this.Resizable = false;
            this.Text = "Редактирование продукта";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.RichTextBox descriprionTextBox;
        private MetroFramework.Controls.MetroDateTime createDateTime;
        private MetroFramework.Controls.MetroLabel modelLabel;
        private MetroFramework.Controls.MetroLabel bodyTypeLabel;
        private MetroFramework.Controls.MetroLabel colorLabel;
        private MetroFramework.Controls.MetroLabel kitLabel;
        private MetroFramework.Controls.MetroLabel discriprionLabel;
        private MetroFramework.Controls.MetroLabel yearLabel;
        private System.Windows.Forms.PictureBox pictureBox;
        private MetroFramework.Controls.MetroLabel photoLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroButton cancelButton;
        private MetroFramework.Controls.MetroButton acceptButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private MetroFramework.Controls.MetroButton removePhotoButton;
        private MetroFramework.Controls.MetroButton addPhotoButton;
        private MetroFramework.Controls.MetroLabel fieldLabel;
        private MetroFramework.Controls.MetroComboBox kitComboBox;
        private MetroFramework.Controls.MetroComboBox modelComboBox;
        private MetroFramework.Controls.MetroComboBox carBodyComboBox;
        private MetroFramework.Controls.MetroComboBox colorComboBox;
        private System.Windows.Forms.Label errorLabel;
    }
}