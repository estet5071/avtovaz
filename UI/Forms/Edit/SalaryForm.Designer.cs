
namespace UI.Forms.Edit
{
    partial class SalaryForm
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
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cancelButton = new MetroFramework.Controls.MetroButton();
            this.acceptButton = new MetroFramework.Controls.MetroButton();
            this.calculateButton = new MetroFramework.Controls.MetroButton();
            this.daySalaryTextBox = new System.Windows.Forms.TextBox();
            this.prizeRatioTextBox = new System.Windows.Forms.TextBox();
            this.workDaysTextBox = new System.Windows.Forms.TextBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.taxTextBox = new System.Windows.Forms.TextBox();
            this.taxDeductionTextBox = new System.Windows.Forms.TextBox();
            this.errorLabel = new MetroFramework.Controls.MetroLabel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(58, 69);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(103, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Дневной оклад";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(11, 115);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(144, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Коэффициент премии";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 162);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(133, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Отработанных дней";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(102, 305);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(45, 19);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "Итого";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.cancelButton);
            this.flowLayoutPanel1.Controls.Add(this.acceptButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(457, 299);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(194, 35);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(4, 3);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(88, 27);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseSelectable = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(100, 3);
            this.acceptButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(88, 27);
            this.acceptButton.TabIndex = 1;
            this.acceptButton.Text = "Применить";
            this.acceptButton.UseSelectable = true;
            this.acceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(556, 253);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(88, 27);
            this.calculateButton.TabIndex = 9;
            this.calculateButton.Text = "Рассчитать";
            this.calculateButton.UseSelectable = true;
            this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // daySalaryTextBox
            // 
            this.daySalaryTextBox.Location = new System.Drawing.Point(168, 72);
            this.daySalaryTextBox.Name = "daySalaryTextBox";
            this.daySalaryTextBox.Size = new System.Drawing.Size(222, 23);
            this.daySalaryTextBox.TabIndex = 10;
            // 
            // prizeRatioTextBox
            // 
            this.prizeRatioTextBox.Location = new System.Drawing.Point(168, 118);
            this.prizeRatioTextBox.Name = "prizeRatioTextBox";
            this.prizeRatioTextBox.Size = new System.Drawing.Size(222, 23);
            this.prizeRatioTextBox.TabIndex = 11;
            // 
            // workDaysTextBox
            // 
            this.workDaysTextBox.Location = new System.Drawing.Point(168, 168);
            this.workDaysTextBox.Name = "workDaysTextBox";
            this.workDaysTextBox.Size = new System.Drawing.Size(222, 23);
            this.workDaysTextBox.TabIndex = 12;
            // 
            // resultTextBox
            // 
            this.resultTextBox.Enabled = false;
            this.resultTextBox.Location = new System.Drawing.Point(168, 301);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(222, 23);
            this.resultTextBox.TabIndex = 13;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(109, 258);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(46, 19);
            this.metroLabel5.TabIndex = 14;
            this.metroLabel5.Text = "НДФЛ";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(40, 213);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(116, 19);
            this.metroLabel6.TabIndex = 15;
            this.metroLabel6.Text = "Налоговый вычет";
            // 
            // taxTextBox
            // 
            this.taxTextBox.Enabled = false;
            this.taxTextBox.Location = new System.Drawing.Point(168, 257);
            this.taxTextBox.Name = "taxTextBox";
            this.taxTextBox.Size = new System.Drawing.Size(222, 23);
            this.taxTextBox.TabIndex = 16;
            // 
            // taxDeductionTextBox
            // 
            this.taxDeductionTextBox.Location = new System.Drawing.Point(168, 213);
            this.taxDeductionTextBox.Name = "taxDeductionTextBox";
            this.taxDeductionTextBox.Size = new System.Drawing.Size(222, 23);
            this.taxDeductionTextBox.TabIndex = 17;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(407, 217);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 0);
            this.errorLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.errorLabel.TabIndex = 18;
            this.errorLabel.UseStyleColors = true;
            // 
            // SalaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 359);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.taxDeductionTextBox);
            this.Controls.Add(this.taxTextBox);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.workDaysTextBox);
            this.Controls.Add(this.prizeRatioTextBox);
            this.Controls.Add(this.daySalaryTextBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "SalaryForm";
            this.Padding = new System.Windows.Forms.Padding(23, 69, 23, 23);
            this.Text = "Плата сотрудникам";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroButton cancelButton;
        private MetroFramework.Controls.MetroButton acceptButton;
        private MetroFramework.Controls.MetroButton calculateButton;
        private System.Windows.Forms.TextBox daySalaryTextBox;
        private System.Windows.Forms.TextBox prizeRatioTextBox;
        private System.Windows.Forms.TextBox workDaysTextBox;
        private System.Windows.Forms.TextBox resultTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.TextBox taxTextBox;
        private System.Windows.Forms.TextBox taxDeductionTextBox;
        private MetroFramework.Controls.MetroLabel errorLabel;
    }
}