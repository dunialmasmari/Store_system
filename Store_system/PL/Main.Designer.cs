namespace Store_system.PL
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.authorizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaleToolStripToolMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PurchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageItemTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeePositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeACopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.authorizationToolStripMenuItem,
            this.employeeToolStripMenuItem,
            this.customersToolStripMenuItem,
            this.companyToolStripMenuItem,
            this.productToolStripMenuItem,
            this.ToolStripMenuItem,
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1203, 30);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // authorizationToolStripMenuItem
            // 
            this.authorizationToolStripMenuItem.Name = "authorizationToolStripMenuItem";
            this.authorizationToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.authorizationToolStripMenuItem.Text = "Authorization";
            this.authorizationToolStripMenuItem.Click += new System.EventHandler(this.authorizationToolStripMenuItem_Click);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.employeeToolStripMenuItem.Text = "Employee";
            this.employeeToolStripMenuItem.Click += new System.EventHandler(this.employeeToolStripMenuItem_Click);
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.customersToolStripMenuItem.Text = "Customers";
            this.customersToolStripMenuItem.Click += new System.EventHandler(this.customersToolStripMenuItem_Click);
            // 
            // companyToolStripMenuItem
            // 
            this.companyToolStripMenuItem.Name = "companyToolStripMenuItem";
            this.companyToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.companyToolStripMenuItem.Text = "Company";
            this.companyToolStripMenuItem.Click += new System.EventHandler(this.companyToolStripMenuItem_Click);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.productToolStripMenuItem.Text = "Product";
            this.productToolStripMenuItem.Click += new System.EventHandler(this.productToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaleToolStripToolMenuItem,
            this.PurchaseToolStripMenuItem});
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.ToolStripMenuItem.Text = "Sale";
            this.ToolStripMenuItem.Click += new System.EventHandler(this.saleToolStripMenuItem_Click);
            // 
            // SaleToolStripToolMenuItem
            // 
            this.SaleToolStripToolMenuItem.Name = "SaleToolStripToolMenuItem";
            this.SaleToolStripToolMenuItem.Size = new System.Drawing.Size(140, 24);
            this.SaleToolStripToolMenuItem.Text = "Sale";
            this.SaleToolStripToolMenuItem.Click += new System.EventHandler(this.addSaleToolStripMenuItem_Click);
            // 
            // PurchaseToolStripMenuItem
            // 
            this.PurchaseToolStripMenuItem.Name = "PurchaseToolStripMenuItem";
            this.PurchaseToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.PurchaseToolStripMenuItem.Text = "Purchase";
            this.PurchaseToolStripMenuItem.Click += new System.EventHandler(this.manageSaleToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.storeToolStripMenuItem,
            this.manageCategoryToolStripMenuItem,
            this.manageItemTypeToolStripMenuItem,
            this.employeePositionToolStripMenuItem,
            this.makeACopyToolStripMenuItem,
            this.restoreToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.fileToolStripMenuItem.Text = "Setting";
            // 
            // storeToolStripMenuItem
            // 
            this.storeToolStripMenuItem.Name = "storeToolStripMenuItem";
            this.storeToolStripMenuItem.Size = new System.Drawing.Size(205, 24);
            this.storeToolStripMenuItem.Text = "Manage Store";
            this.storeToolStripMenuItem.Click += new System.EventHandler(this.storeToolStripMenuItem_Click);
            // 
            // manageCategoryToolStripMenuItem
            // 
            this.manageCategoryToolStripMenuItem.Name = "manageCategoryToolStripMenuItem";
            this.manageCategoryToolStripMenuItem.Size = new System.Drawing.Size(205, 24);
            this.manageCategoryToolStripMenuItem.Text = "Manage Category ";
            this.manageCategoryToolStripMenuItem.Click += new System.EventHandler(this.manageCategoryToolStripMenuItem_Click);
            // 
            // manageItemTypeToolStripMenuItem
            // 
            this.manageItemTypeToolStripMenuItem.Name = "manageItemTypeToolStripMenuItem";
            this.manageItemTypeToolStripMenuItem.Size = new System.Drawing.Size(205, 24);
            this.manageItemTypeToolStripMenuItem.Text = "Manage item Type";
            this.manageItemTypeToolStripMenuItem.Click += new System.EventHandler(this.manageItemTypeToolStripMenuItem_Click);
            // 
            // employeePositionToolStripMenuItem
            // 
            this.employeePositionToolStripMenuItem.Name = "employeePositionToolStripMenuItem";
            this.employeePositionToolStripMenuItem.Size = new System.Drawing.Size(205, 24);
            this.employeePositionToolStripMenuItem.Text = "Employee Position";
            this.employeePositionToolStripMenuItem.Click += new System.EventHandler(this.employeePositionToolStripMenuItem_Click);
            // 
            // makeACopyToolStripMenuItem
            // 
            this.makeACopyToolStripMenuItem.Name = "makeACopyToolStripMenuItem";
            this.makeACopyToolStripMenuItem.Size = new System.Drawing.Size(205, 24);
            this.makeACopyToolStripMenuItem.Text = "Back Up";
            this.makeACopyToolStripMenuItem.Click += new System.EventHandler(this.makeACopyToolStripMenuItem_Click);
            // 
            // restoreToolStripMenuItem
            // 
            this.restoreToolStripMenuItem.Name = "restoreToolStripMenuItem";
            this.restoreToolStripMenuItem.Size = new System.Drawing.Size(205, 24);
            this.restoreToolStripMenuItem.Text = "Restore";
            this.restoreToolStripMenuItem.Click += new System.EventHandler(this.restoreToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(205, 24);
            this.logOutToolStripMenuItem.Text = "log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 559);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1203, 25);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(153, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1203, 584);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem authorizationToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem companyToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeACopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageItemTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem employeePositionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem storeToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem SaleToolStripToolMenuItem;
        public System.Windows.Forms.ToolStripMenuItem PurchaseToolStripMenuItem;
    }
}