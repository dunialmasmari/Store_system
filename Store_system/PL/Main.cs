using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;


namespace Store_system.PL
{
    public partial class Main : Form
    {

        SqlConnection cn = new SqlConnection(" server=.;integrated security=true;dataBase=store_system");

        SqlCommand cmd;
        SqlDataReader dr;
        public Main(string x)
        {
            InitializeComponent();
            LogIn f=new LogIn();
           

            toolStripStatusLabel1.Text = "TODAY IS: " + DateTime.Now + "                    PC :" + Environment.MachineName +"                               employee Name:"+x +"";

        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee f = new Employee();
            f.Show();
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee f = new Employee();
            f.Show();
        }

        private void managgeProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product d = new Product();
            d.Show();
        }

        private void authorizationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Authorization f = new Authorization();
            f.Show();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product f = new Product();
            f.Show();

        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerCompany f = new CustomerCompany();
            f.Show();

        }

        private void companyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BL.clscustomercompany c = new BL.clscustomercompany();

            CustomerCompany f = new CustomerCompany();
            f.label8.Text = "Manage Company";
            f.dataGridView1.DataSource = c.Get_All_Company();
            f.dataGridView1.AutoGenerateColumns = false;
            f.Show();
        }

        private void addSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sale f = new Sale();

            f.Show();

        }

        private void Main_Load(object sender, EventArgs e)
        {
            //toolStripStatusLabel1.Text = "TODAY IS: " + DateTime.Now + "                    PC :" + Environment.MachineName + "                               employee Name:" + Program.empname + "";

        }
      
        public void Createconnection()
        {
            cn = new SqlConnection(" Data Source=.;integrated security=true;dataBase=store_system");
            cn.Open();
         
            cmd = new SqlCommand("select * from sysdatabases where name='store_system'",cn);
            dr = cmd.ExecuteReader();

            dr.Close();


        }
        public void quary(string que)
        {
            cn.Open();   
            cmd = new SqlCommand(que, cn);
            cmd.ExecuteNonQuery();

        }
        public void blank(string str)
        {
            Createconnection();
            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
                      
                if (str=="backup")
                {
                    SaveFileDialog f = new SaveFileDialog();
                    f.Filter = "Backup Files (*.Bak)|*.bak";
                    f.FileName = "store_system";
                    f.ShowDialog();
                    string s = null;
                    s = f.FileName;
                    quary("Backup database store_system to disk='" + s + "'");
                    MessageBox.Show("Backup seccess");
                    
                }
               else
                    if (str=="restore")
                    {
                       
                        OpenFileDialog m = new OpenFileDialog();
                        m.Filter = "Backup Files (*.Bak)|*.bak";

                        m.FileName = ".Bak";
                        string s = null;
                        s =m.FileName;
                   
                        quary(" if exists (select name from master.dbo.sysdatabases where name =N'"+s+"') drop database store_system Restore Database store_system from disk='"+m.FileName+"'");
                        MessageBox.Show("Restore succeded", "restore", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
            
        }
        private void saleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manageSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Purchase f = new Purchase();
            f.Show();
        }

        private void makeACopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blank("backup");
        
        }

        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blank("restore");
        
        }

        private void storeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Store f = new Store();
            f.Show();
        }

        private void manageCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Category f = new Category();
            f.Show();
        }

        private void manageItemTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductType f = new ProductType();
            f.Show();
        }

        private void employeePositionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Position f = new Position();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
       
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
