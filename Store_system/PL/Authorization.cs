using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_system.PL
{
    public partial class Authorization : Form
    {
        Main main = new Main(Program.empname);
           
         
       
        public Authorization()
        {
            InitializeComponent();

            string autho = (main.authorizationToolStripMenuItem.Enabled = true).ToString();
            string co = (main.companyToolStripMenuItem.Enabled = true).ToString();
            string cu = (main.customersToolStripMenuItem.Enabled = true).ToString();
            string emp = (main.employeeToolStripMenuItem.Enabled = true).ToString();
            string prd = (main.productToolStripMenuItem.Enabled = true).ToString();
            string sale = (main.SaleToolStripToolMenuItem.Enabled = true).ToString();
            string purchase = (main.PurchaseToolStripMenuItem.Enabled = true).ToString();



        }

        private void Authorization_Load(object sender, EventArgs e)
        {
           
          


            
        }

        private void empnametxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            empname.Clear();
            textBox2.Clear();
            textBox3.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            groupBox2.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            
                groupBox2.Enabled = true;
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
}
