
namespace UI.Forms
{
    partial class ReportForm
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.pathButton = new MetroFramework.Controls.MetroButton();
            this.orderRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.productsRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.customersRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.startDateCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.endDateCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.startDateTime = new MetroFramework.Controls.MetroDateTime();
            this.endDateTime = new MetroFramework.Controls.MetroDateTime();
            this.uploadButton = new MetroFramework.Controls.MetroButton();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.errorLabel = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(14, 80);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(75, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Тип отчета";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(14, 135);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(38, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Путь:";
            // 
            // pathButton
            // 
            this.pathButton.Location = new System.Drawing.Point(460, 135);
            this.pathButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pathButton.Name = "pathButton";
            this.pathButton.Size = new System.Drawing.Size(88, 23);
            this.pathButton.TabIndex = 3;
            this.pathButton.Text = "Выбрать";
            this.pathButton.UseSelectable = true;
            this.pathButton.Click += new System.EventHandler(this.PathButton_Click);
            // 
            // orderRadioButton
            // 
            this.orderRadioButton.AutoSize = true;
            this.orderRadioButton.Location = new System.Drawing.Point(131, 84);
            this.orderRadioButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.orderRadioButton.Name = "orderRadioButton";
            this.orderRadioButton.Size = new System.Drawing.Size(62, 15);
            this.orderRadioButton.TabIndex = 4;
            this.orderRadioButton.Tag = "1";
            this.orderRadioButton.Text = "Заказы";
            this.orderRadioButton.UseSelectable = true;
            this.orderRadioButton.Click += new System.EventHandler(this.SomeRadioButton_Click);
            // 
            // productsRadioButton
            // 
            this.productsRadioButton.AutoSize = true;
            this.productsRadioButton.Location = new System.Drawing.Point(245, 84);
            this.productsRadioButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.productsRadioButton.Name = "productsRadioButton";
            this.productsRadioButton.Size = new System.Drawing.Size(78, 15);
            this.productsRadioButton.TabIndex = 5;
            this.productsRadioButton.Tag = "2";
            this.productsRadioButton.Text = "Продукты";
            this.productsRadioButton.UseSelectable = true;
            this.productsRadioButton.Click += new System.EventHandler(this.SomeRadioButton_Click);
            // 
            // customersRadioButton
            // 
            this.customersRadioButton.AutoSize = true;
            this.customersRadioButton.Location = new System.Drawing.Point(379, 84);
            this.customersRadioButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.customersRadioButton.Name = "customersRadioButton";
            this.customersRadioButton.Size = new System.Drawing.Size(71, 15);
            this.customersRadioButton.TabIndex = 6;
            this.customersRadioButton.Tag = "3";
            this.customersRadioButton.Text = "Клиенты";
            this.customersRadioButton.UseSelectable = true;
            this.customersRadioButton.Click += new System.EventHandler(this.SomeRadioButton_Click);
            // 
            // startDateCheckBox
            // 
            this.startDateCheckBox.AutoSize = true;
            this.startDateCheckBox.Location = new System.Drawing.Point(38, 237);
            this.startDateCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.startDateCheckBox.Name = "startDateCheckBox";
            this.startDateCheckBox.Size = new System.Drawing.Size(90, 15);
            this.startDateCheckBox.TabIndex = 7;
            this.startDateCheckBox.Text = "Дата начала";
            this.startDateCheckBox.UseSelectable = true;
            this.startDateCheckBox.CheckedChanged += new System.EventHandler(this.StartDateCheckBox_CheckedChanged);
            // 
            // endDateCheckBox
            // 
            this.endDateCheckBox.AutoSize = true;
            this.endDateCheckBox.Location = new System.Drawing.Point(38, 284);
            this.endDateCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.endDateCheckBox.Name = "endDateCheckBox";
            this.endDateCheckBox.Size = new System.Drawing.Size(111, 15);
            this.endDateCheckBox.TabIndex = 8;
            this.endDateCheckBox.Text = "Дата окончания";
            this.endDateCheckBox.UseSelectable = true;
            this.endDateCheckBox.CheckedChanged += new System.EventHandler(this.EndDateCheckBox_CheckedChanged);
            // 
            // startDateTime
            // 
            this.startDateTime.Enabled = false;
            this.startDateTime.Location = new System.Drawing.Point(168, 237);
            this.startDateTime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.startDateTime.MinimumSize = new System.Drawing.Size(0, 29);
            this.startDateTime.Name = "startDateTime";
            this.startDateTime.Size = new System.Drawing.Size(233, 29);
            this.startDateTime.TabIndex = 9;
            // 
            // endDateTime
            // 
            this.endDateTime.Enabled = false;
            this.endDateTime.Location = new System.Drawing.Point(168, 284);
            this.endDateTime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.endDateTime.MinimumSize = new System.Drawing.Size(0, 29);
            this.endDateTime.Name = "endDateTime";
            this.endDateTime.Size = new System.Drawing.Size(233, 29);
            this.endDateTime.TabIndex = 10;
            // 
            // uploadButton
            // 
            this.uploadButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.uploadButton.Location = new System.Drawing.Point(460, 270);
            this.uploadButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(113, 44);
            this.uploadButton.TabIndex = 11;
            this.uploadButton.Text = "Выгрузить";
            this.uploadButton.UseSelectable = true;
            this.uploadButton.Click += new System.EventHandler(this.UploadButton_Click);
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(59, 135);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(391, 23);
            this.pathTextBox.TabIndex = 12;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(55, 113);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 0);
            this.errorLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.errorLabel.TabIndex = 13;
            this.errorLabel.UseStyleColors = true;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 331);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.uploadButton);
            this.Controls.Add(this.endDateTime);
            this.Controls.Add(this.startDateTime);
            this.Controls.Add(this.endDateCheckBox);
            this.Controls.Add(this.startDateCheckBox);
            this.Controls.Add(this.customersRadioButton);
            this.Controls.Add(this.productsRadioButton);
            this.Controls.Add(this.orderRadioButton);
            this.Controls.Add(this.pathButton);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(588, 331);
            this.MinimumSize = new System.Drawing.Size(588, 331);
            this.Name = "ReportForm";
            this.Padding = new System.Windows.Forms.Padding(23, 69, 23, 23);
            this.Text = "Выгрузка в exel";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton pathButton;
        private MetroFramework.Controls.MetroRadioButton orderRadioButton;
        private MetroFramework.Controls.MetroRadioButton productsRadioButton;
        private MetroFramework.Controls.MetroRadioButton customersRadioButton;
        private MetroFramework.Controls.MetroCheckBox startDateCheckBox;
        private MetroFramework.Controls.MetroCheckBox endDateCheckBox;
        private MetroFramework.Controls.MetroDateTime startDateTime;
        private MetroFramework.Controls.MetroDateTime endDateTime;
        private MetroFramework.Controls.MetroButton uploadButton;
        private System.Windows.Forms.TextBox pathTextBox;
        private MetroFramework.Controls.MetroLabel errorLabel;
    }
}