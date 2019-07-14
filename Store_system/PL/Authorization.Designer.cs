namespace Store_system.PL
{
    partial class Authorization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Employee_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorizationType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autorizations = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.simpleButton3 = new System.Windows.Forms.Button();
            this.simpleButton2 = new System.Windows.Forms.Button();
            this.simpleButton1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Manage = new System.Windows.Forms.CheckBox();
            this.Product = new System.Windows.Forms.CheckBox();
            this.Cust = new System.Windows.Forms.CheckBox();
            this.Sale = new System.Windows.Forms.CheckBox();
            this.Purchase = new System.Windows.Forms.CheckBox();
            this.Emp = new System.Windows.Forms.CheckBox();
            this.Comp = new System.Windows.Forms.CheckBox();
            this.Auth = new System.Windows.Forms.CheckBox();
            this.Autho = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.empname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.Autho.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Employee_Name,
            this.User_Name,
            this.Password,
            this.AuthorizationType,
            this.Autorizations});
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // Employee_Name
            // 
            resources.ApplyResources(this.Employee_Name, "Employee_Name");
            this.Employee_Name.Name = "Employee_Name";
            // 
            // User_Name
            // 
            resources.ApplyResources(this.User_Name, "User_Name");
            this.User_Name.Name = "User_Name";
            // 
            // Password
            // 
            resources.ApplyResources(this.Password, "Password");
            this.Password.Name = "Password";
            // 
            // AuthorizationType
            // 
            resources.ApplyResources(this.AuthorizationType, "AuthorizationType");
            this.AuthorizationType.Name = "AuthorizationType";
            // 
            // Autorizations
            // 
            resources.ApplyResources(this.Autorizations, "Autorizations");
            this.Autorizations.Name = "Autorizations";
            // 
            // simpleButton3
            // 
            this.simpleButton3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.simpleButton3, "simpleButton3");
            this.simpleButton3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.UseVisualStyleBackColor = false;
            // 
            // simpleButton2
            // 
            this.simpleButton2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.simpleButton2, "simpleButton2");
            this.simpleButton2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.UseVisualStyleBackColor = false;
            // 
            // simpleButton1
            // 
            this.simpleButton1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.simpleButton1, "simpleButton1");
            this.simpleButton1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Manage);
            this.groupBox2.Controls.Add(this.Product);
            this.groupBox2.Controls.Add(this.Cust);
            this.groupBox2.Controls.Add(this.Sale);
            this.groupBox2.Controls.Add(this.Purchase);
            this.groupBox2.Controls.Add(this.Emp);
            this.groupBox2.Controls.Add(this.Comp);
            this.groupBox2.Controls.Add(this.Auth);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // Manage
            // 
            resources.ApplyResources(this.Manage, "Manage");
            this.Manage.Name = "Manage";
            this.Manage.UseVisualStyleBackColor = true;
            // 
            // Product
            // 
            resources.ApplyResources(this.Product, "Product");
            this.Product.Name = "Product";
            this.Product.UseVisualStyleBackColor = true;
            // 
            // Cust
            // 
            resources.ApplyResources(this.Cust, "Cust");
            this.Cust.Name = "Cust";
            this.Cust.UseVisualStyleBackColor = true;
            // 
            // Sale
            // 
            resources.ApplyResources(this.Sale, "Sale");
            this.Sale.Name = "Sale";
            this.Sale.UseVisualStyleBackColor = true;
            // 
            // Purchase
            // 
            resources.ApplyResources(this.Purchase, "Purchase");
            this.Purchase.Name = "Purchase";
            this.Purchase.UseVisualStyleBackColor = true;
            // 
            // Emp
            // 
            resources.ApplyResources(this.Emp, "Emp");
            this.Emp.Name = "Emp";
            this.Emp.UseVisualStyleBackColor = true;
            // 
            // Comp
            // 
            resources.ApplyResources(this.Comp, "Comp");
            this.Comp.Name = "Comp";
            this.Comp.UseVisualStyleBackColor = true;
            // 
            // Auth
            // 
            resources.ApplyResources(this.Auth, "Auth");
            this.Auth.Name = "Auth";
            this.Auth.UseVisualStyleBackColor = true;
            this.Auth.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Autho
            // 
            this.Autho.Controls.Add(this.textBox3);
            this.Autho.Controls.Add(this.radioButton2);
            this.Autho.Controls.Add(this.radioButton1);
            this.Autho.Controls.Add(this.textBox2);
            this.Autho.Controls.Add(this.empname);
            this.Autho.Controls.Add(this.label4);
            this.Autho.Controls.Add(this.label3);
            this.Autho.Controls.Add(this.label2);
            this.Autho.Controls.Add(this.label1);
            resources.ApplyResources(this.Autho, "Autho");
            this.Autho.Name = "Autho";
            this.Autho.TabStop = false;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.Name = "textBox3";
            // 
            // radioButton2
            // 
            resources.ApplyResources(this.radioButton2, "radioButton2");
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            resources.ApplyResources(this.radioButton1, "radioButton1");
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            // 
            // empname
            // 
            this.empname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.empname, "empname");
            this.empname.Name = "empname";
            this.empname.TextChanged += new System.EventHandler(this.empnametxtbox_TextChanged);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.button2, "button2");
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGreen;
            this.panel1.Controls.Add(this.label8);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Name = "label8";
            // 
            // Authorization
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Autho);
            this.Name = "Authorization";
            this.Load += new System.EventHandler(this.Authorization_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Autho.ResumeLayout(false);
            this.Autho.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button simpleButton3;
        private System.Windows.Forms.Button simpleButton2;
        private System.Windows.Forms.Button simpleButton1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox Manage;
        private System.Windows.Forms.CheckBox Product;
        private System.Windows.Forms.CheckBox Cust;
        private System.Windows.Forms.CheckBox Sale;
        private System.Windows.Forms.CheckBox Purchase;
        private System.Windows.Forms.CheckBox Emp;
        private System.Windows.Forms.CheckBox Comp;
        private System.Windows.Forms.CheckBox Auth;
        private System.Windows.Forms.GroupBox Autho;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox empname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorizationType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autorizations;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
    }
}