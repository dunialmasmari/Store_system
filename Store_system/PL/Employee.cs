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


namespace Store_system.PL
{
    public partial class Employee : Form
    {
        BL.clsemployee Emp = new BL.clsemployee();
        public Employee()
        {
            InitializeComponent();

            comboBox1.DataSource = Emp.Get_All_Position();
            comboBox1.DisplayMember = "empposition_name";
            comboBox1.ValueMember = "empposition_no";
            comboBox2.DataSource = Emp.Get_All_Store();
            comboBox2.DisplayMember = "storename";
            comboBox2.ValueMember = "storeno";
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Authorization f = new Authorization();
            f.Show();
        }

        private void simpleButton4_Validated(object sender, EventArgs e)
        {
            

        }

        private void Employee_Load(object sender, EventArgs e)
        {
            textBox1.Text = Emp.maxemp().Rows[0][0].ToString();
            

            
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = Emp.Get_All_Employee();
   

            if (empname.Text != "" || empphone.Text != "" || empaddress.Text != "" )
            {
                simpleButton4.Enabled = false;
            }

           


         
          
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || empname.Text == "" || empphone.Text == "" || empaddress.Text == "")
            {
                MessageBox.Show("You Cant do anything if the boxes are empty  ", "Warning  ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                Emp.AddEmployee(Convert.ToInt32(textBox1.Text), empname.Text, empphone.Text, empaddress.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(comboBox2.SelectedValue));
                MessageBox.Show("Add Seccess", "Add Product ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dataGridView1.DataSource = Emp.Get_All_Employee();

                textBox1.Text = Emp.maxemp().Rows[0][0].ToString();
                empname.Clear();
                empaddress.Clear();
                empphone.Clear();
                label9.Text = "";
            }

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || empname.Text == "" || empphone.Text == "" || empaddress.Text == "" )
            {
                MessageBox.Show("You Cant do anything if the boxes are empty  ", "Warning  ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {

                Emp.UpdateEmployee(Convert.ToInt32(textBox1.Text), empname.Text, empphone.Text, empaddress.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(comboBox2.SelectedValue));
                MessageBox.Show("Update Seccess", "Update Product ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dataGridView1.DataSource = Emp.Get_All_Employee();
                textBox1.Text = Emp.maxemp().Rows[0][0].ToString();
                empname.Clear();
                empaddress.Clear();
                empphone.Clear();
                label9.Text = "";
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
          
                if (MessageBox.Show("Do you realy want to delete this Product ?", "Delete Product", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    Emp.DeleteEmployee(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value));
                    MessageBox.Show("Delete successful", "Delete Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dataGridView1.DataSource = Emp.Get_All_Employee();


                }
                else
                {
                    MessageBox.Show("Delete Cancled", "Delete Product", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
        

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

            textBox1.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells[0].Value);
            empname.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells[1].Value);
            empphone.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells[2].Value);
            empaddress.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells[3].Value);
            comboBox1.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells[4].Value);
            label9.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells[5].Value);
            comboBox2.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells[6].Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = Emp.maxemp().Rows[0][0].ToString();
            empname.Clear();
            empaddress.Clear();
            empphone.Clear();
            label9.Text = "";


          
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
           
           SqlConnection con = new SqlConnection(" server=THENME-PC;integrated security=true;dataBase=store_system");

            DataTable dt = new DataTable();

            string s = "select empposition_salary from empposition where empposition_name='" + comboBox1.Text + "'";

            SqlDataAdapter da = new SqlDataAdapter(s, con);
            da.Fill(dt);
            string d = dt.Rows[0][0].ToString();
            label9.Text = d;


            
        }
       
        private void comboBox2_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void empname_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (Char.IsDigit(ch) && ch != 8)
            {

                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                empphone.Focus();
            }
        }

        private void empphone_KeyPress(object sender, KeyPressEventArgs e)
        {
          
            if (e.KeyChar == 13)
            {
                empaddress.Focus();
            }
        }

        private void empaddress_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (e.KeyChar == 13)
            {
                comboBox1.Focus();
            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (e.KeyChar == 13)
            {
                comboBox2.Focus();
            }
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == 13)
            {
               button1.Focus();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
