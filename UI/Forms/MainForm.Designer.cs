
namespace UI.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroToggle = new MetroFramework.Controls.MetroToggle();
            this.menulbl = new MetroFramework.Controls.MetroLabel();
            this.empoyeesButton = new MetroFramework.Controls.MetroButton();
            this.customersButton = new MetroFramework.Controls.MetroButton();
            this.productButton = new MetroFramework.Controls.MetroButton();
            this.orderButton = new MetroFramework.Controls.MetroButton();
            this.unloadReportButton = new MetroFramework.Controls.MetroButton();
            this.userInfo = new MetroFramework.Controls.MetroLabel();
            this.browserPanel = new MetroFramework.Controls.MetroPanel();
            this.exitButton = new MetroFramework.Controls.MetroButton();
            this.changeUserButton = new MetroFramework.Controls.MetroButton();
            this.exitAndChangeUserPanel = new System.Windows.Forms.TableLayoutPanel();
            this.sectionButtonsPanel = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.exitAndChangeUserPanel.SuspendLayout();
            this.sectionButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // metroToggle
            // 
            this.metroToggle.Checked = true;
            this.metroToggle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.metroToggle.DisplayStatus = false;
            this.metroToggle.Location = new System.Drawing.Point(193, 24);
            this.metroToggle.Name = "metroToggle";
            this.metroToggle.Size = new System.Drawing.Size(59, 22);
            this.metroToggle.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroToggle.TabIndex = 4;
            this.metroToggle.Tag = "";
            this.metroToggle.Text = "On";
            this.metroToggle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroToggle.UseSelectable = true;
            this.metroToggle.UseStyleColors = true;
            this.metroToggle.CheckStateChanged += new System.EventHandler(this.MetroToggle_CheckStateChanged);
            // 
            // menulbl
            // 
            this.menulbl.AutoSize = true;
            this.menulbl.Location = new System.Drawing.Point(140, 24);
            this.menulbl.Name = "menulbl";
            this.menulbl.Size = new System.Drawing.Size(47, 19);
            this.menulbl.TabIndex = 5;
            this.menulbl.Text = "Меню";
            // 
            // empoyeesButton
            // 
            this.empoyeesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.empoyeesButton.BackColor = System.Drawing.Color.White;
            this.empoyeesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.empoyeesButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.empoyeesButton.Location = new System.Drawing.Point(6, 6);
            this.empoyeesButton.Name = "empoyeesButton";
            this.empoyeesButton.Size = new System.Drawing.Size(112, 53);
            this.empoyeesButton.TabIndex = 0;
            this.empoyeesButton.Text = "Работники";
            this.empoyeesButton.UseSelectable = true;
            this.empoyeesButton.UseVisualStyleBackColor = false;
            this.empoyeesButton.Click += new System.EventHandler(this.EmpoyeesButton_Click);
            // 
            // customersButton
            // 
            this.customersButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customersButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.customersButton.Location = new System.Drawing.Point(6, 68);
            this.customersButton.Name = "customersButton";
            this.customersButton.Size = new System.Drawing.Size(112, 53);
            this.customersButton.TabIndex = 1;
            this.customersButton.Text = "Клиенты";
            this.customersButton.UseSelectable = true;
            this.customersButton.Click += new System.EventHandler(this.CustomersButton_Click);
            // 
            // productButton
            // 
            this.productButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.productButton.Location = new System.Drawing.Point(6, 130);
            this.productButton.Name = "productButton";
            this.productButton.Size = new System.Drawing.Size(112, 53);
            this.productButton.TabIndex = 2;
            this.productButton.Text = "Продукты";
            this.productButton.UseSelectable = true;
            this.productButton.Click += new System.EventHandler(this.ProductButton_Click);
            // 
            // orderButton
            // 
            this.orderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.orderButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.orderButton.Location = new System.Drawing.Point(6, 192);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(112, 53);
            this.orderButton.TabIndex = 3;
            this.orderButton.Text = "Заказы";
            this.orderButton.UseSelectable = true;
            this.orderButton.Click += new System.EventHandler(this.OrderButton_Click);
            // 
            // unloadReportButton
            // 
            this.unloadReportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.unloadReportButton.AutoSize = true;
            this.unloadReportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.unloadReportButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.unloadReportButton.Location = new System.Drawing.Point(6, 254);
            this.unloadReportButton.Name = "unloadReportButton";
            this.unloadReportButton.Size = new System.Drawing.Size(112, 54);
            this.unloadReportButton.TabIndex = 10;
            this.unloadReportButton.Text = "Выгрузить \r\nотчет";
            this.unloadReportButton.UseSelectable = true;
            this.unloadReportButton.Click += new System.EventHandler(this.UnloadReportButton_Click);
            // 
            // userInfo
            // 
            this.userInfo.AutoSize = true;
            this.userInfo.Location = new System.Drawing.Point(331, 23);
            this.userInfo.Name = "userInfo";
            this.userInfo.Size = new System.Drawing.Size(0, 0);
            this.userInfo.TabIndex = 7;
            // 
            // browserPanel
            // 
            this.browserPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.browserPanel.AutoScroll = true;
            this.browserPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.browserPanel.HorizontalScrollbar = true;
            this.browserPanel.HorizontalScrollbarBarColor = true;
            this.browserPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.browserPanel.HorizontalScrollbarSize = 10;
            this.browserPanel.Location = new System.Drawing.Point(140, 55);
            this.browserPanel.Name = "browserPanel";
            this.browserPanel.Size = new System.Drawing.Size(1035, 454);
            this.browserPanel.TabIndex = 8;
            this.browserPanel.VerticalScrollbar = true;
            this.browserPanel.VerticalScrollbarBarColor = true;
            this.browserPanel.VerticalScrollbarHighlightOnWheel = false;
            this.browserPanel.VerticalScrollbarSize = 10;
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.exitButton.Location = new System.Drawing.Point(6, 57);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(112, 42);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Выход";
            this.exitButton.UseSelectable = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // changeUserButton
            // 
            this.changeUserButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.changeUserButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.changeUserButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeUserButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.changeUserButton.Location = new System.Drawing.Point(6, 6);
            this.changeUserButton.Name = "changeUserButton";
            this.changeUserButton.Size = new System.Drawing.Size(112, 42);
            this.changeUserButton.TabIndex = 0;
            this.changeUserButton.Text = "Сменить \r\nпользователя";
            this.changeUserButton.UseSelectable = true;
            this.changeUserButton.Click += new System.EventHandler(this.ChangeUserButton_Click);
            // 
            // exitAndChangeUserPanel
            // 
            this.exitAndChangeUserPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.exitAndChangeUserPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.exitAndChangeUserPanel.ColumnCount = 1;
            this.exitAndChangeUserPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.exitAndChangeUserPanel.Controls.Add(this.exitButton, 0, 1);
            this.exitAndChangeUserPanel.Controls.Add(this.changeUserButton, 0, 0);
            this.exitAndChangeUserPanel.Location = new System.Drawing.Point(0, 404);
            this.exitAndChangeUserPanel.Name = "exitAndChangeUserPanel";
            this.exitAndChangeUserPanel.RowCount = 2;
            this.exitAndChangeUserPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.exitAndChangeUserPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.exitAndChangeUserPanel.Size = new System.Drawing.Size(124, 105);
            this.exitAndChangeUserPanel.TabIndex = 9;
            // 
            // sectionButtonsPanel
            // 
            this.sectionButtonsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sectionButtonsPanel.AutoSize = true;
            this.sectionButtonsPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.sectionButtonsPanel.ColumnCount = 1;
            this.sectionButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sectionButtonsPanel.Controls.Add(this.unloadReportButton, 0, 4);
            this.sectionButtonsPanel.Controls.Add(this.orderButton, 0, 3);
            this.sectionButtonsPanel.Controls.Add(this.productButton, 0, 2);
            this.sectionButtonsPanel.Controls.Add(this.customersButton, 0, 1);
            this.sectionButtonsPanel.Controls.Add(this.empoyeesButton, 0, 0);
            this.sectionButtonsPanel.Location = new System.Drawing.Point(0, 55);
            this.sectionButtonsPanel.Name = "sectionButtonsPanel";
            this.sectionButtonsPanel.RowCount = 5;
            this.sectionButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.sectionButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.sectionButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.sectionButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.sectionButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.sectionButtonsPanel.Size = new System.Drawing.Size(124, 314);
            this.sectionButtonsPanel.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1187, 532);
            this.Controls.Add(this.sectionButtonsPanel);
            this.Controls.Add(this.exitAndChangeUserPanel);
            this.Controls.Add(this.browserPanel);
            this.Controls.Add(this.userInfo);
            this.Controls.Add(this.menulbl);
            this.Controls.Add(this.metroToggle);
            this.Controls.Add(this.pictureBox1);
            this.MinimumSize = new System.Drawing.Size(855, 446);
            this.Name = "MainForm";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.exitAndChangeUserPanel.ResumeLayout(false);
            this.sectionButtonsPanel.ResumeLayout(false);
            this.sectionButtonsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroToggle metroToggle;
        private MetroFramework.Controls.MetroLabel menulbl;
        private MetroFramework.Controls.MetroButton empoyeesButton;
        private MetroFramework.Controls.MetroLabel userInfo;
        private MetroFramework.Controls.MetroButton customersButton;
        private MetroFramework.Controls.MetroButton productButton;
        private MetroFramework.Controls.MetroButton orderButton;
        private MetroFramework.Controls.MetroPanel browserPanel;
        private MetroFramework.Controls.MetroButton unloadReportButton;
        private MetroFramework.Controls.MetroButton exitButton;
        private MetroFramework.Controls.MetroButton changeUserButton;
        private System.Windows.Forms.TableLayoutPanel exitAndChangeUserPanel;
        private System.Windows.Forms.TableLayoutPanel sectionButtonsPanel;
    }
}