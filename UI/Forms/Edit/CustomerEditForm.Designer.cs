
namespace UI.Forms.Edit
{
    partial class CustomerEditForm
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
            this.nameLabel = new MetroFramework.Controls.MetroLabel();
            this.phoneLabel = new MetroFramework.Controls.MetroLabel();
            this.emailLabel = new MetroFramework.Controls.MetroLabel();
            this.adressLabel = new MetroFramework.Controls.MetroLabel();
            this.requiredFieldLabel = new MetroFramework.Controls.MetroLabel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.phoneTextBox = new System.Windows.Forms.MaskedTextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(38, 122);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(74, 19);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Название*";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(46, 175);
            this.phoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(68, 19);
            this.phoneLabel.TabIndex = 5;
            this.phoneLabel.Text = "Телефон*";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(327, 122);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(41, 19);
            this.emailLabel.TabIndex = 6;
            this.emailLabel.Text = "Email";
            // 
            // adressLabel
            // 
            this.adressLabel.AutoSize = true;
            this.adressLabel.Location = new System.Drawing.Point(314, 175);
            this.adressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.adressLabel.Name = "adressLabel";
            this.adressLabel.Size = new System.Drawing.Size(52, 19);
            this.adressLabel.TabIndex = 7;
            this.adressLabel.Text = "Адрес*";
            // 
            // requiredFieldLabel
            // 
            this.requiredFieldLabel.AutoSize = true;
            this.requiredFieldLabel.Location = new System.Drawing.Point(27, 69);
            this.requiredFieldLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.requiredFieldLabel.Name = "requiredFieldLabel";
            this.requiredFieldLabel.Size = new System.Drawing.Size(148, 19);
            this.requiredFieldLabel.TabIndex = 8;
            this.requiredFieldLabel.Text = "* - обязательные поля";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(4, 3);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(88, 27);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.Text = "Отменить";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(100, 3);
            this.acceptButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(104, 27);
            this.acceptButton.TabIndex = 14;
            this.acceptButton.Text = "Подтвердить";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoSize = true;
            this.flowLayoutPanel.Controls.Add(this.cancelButton);
            this.flowLayoutPanel.Controls.Add(this.acceptButton);
            this.flowLayoutPanel.Location = new System.Drawing.Point(430, 263);
            this.flowLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(208, 33);
            this.flowLayoutPanel.TabIndex = 15;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(125, 179);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.phoneTextBox.Mask = "+7 (000) 000-00-00";
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(181, 23);
            this.phoneTextBox.TabIndex = 17;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(375, 124);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(218, 23);
            this.emailTextBox.TabIndex = 18;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(375, 179);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(218, 23);
            this.addressTextBox.TabIndex = 19;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(125, 124);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(181, 23);
            this.nameTextBox.TabIndex = 20;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(194, 69);
            this.errorLabel.MaximumSize = new System.Drawing.Size(450, 0);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 15);
            this.errorLabel.TabIndex = 22;
            // 
            // CustomerEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 312);
            this.ControlBox = false;
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.requiredFieldLabel);
            this.Controls.Add(this.adressLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.nameLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(663, 312);
            this.Name = "CustomerEditForm";
            this.Padding = new System.Windows.Forms.Padding(23, 69, 23, 23);
            this.Resizable = false;
            this.Text = "Изменение данных клиента";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.flowLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       
        private MetroFramework.Controls.MetroLabel nameLabel;
        private MetroFramework.Controls.MetroLabel phoneLabel;
        private MetroFramework.Controls.MetroLabel emailLabel;
        private MetroFramework.Controls.MetroLabel adressLabel;
        private MetroFramework.Controls.MetroLabel requiredFieldLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.MaskedTextBox phoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label errorLabel;
    }
}