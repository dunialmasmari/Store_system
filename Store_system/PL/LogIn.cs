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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }
         BL.clslogin log = new BL.clslogin();
       

        
        private void LogIn_Load(object sender, EventArgs e)
        {
            txtid.Focus();
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            DataTable Dt = log.LOGIN(txtid.Text, txtpwd.Text);
            if (Dt.Rows.Count > 0)
            {
              
                

                Program.empname = Dt.Rows[0]["empname"].ToString();
                Program.empno = Convert.ToInt32(Dt.Rows[0]["empno"]);
            
                Main f = new Main(Program.empname.ToString());
                f.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Login Faild !");
            }

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtid_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                txtpwd.Focus();
            }
        }

        private void txtpwd_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                simpleButton1.Focus();
               
            }
        }
    }
}
