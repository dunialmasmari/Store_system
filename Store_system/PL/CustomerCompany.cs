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
    public partial class CustomerCompany : Form
    {
        BL.clscustomercompany c = new BL.clscustomercompany();

        public CustomerCompany()
        {
            InitializeComponent();
           
     

        }

        private void CustomerCompany_Load(object sender, EventArgs e)

        
        {
         

            if( label8.Text=="Manage Customer")
            {
            textBox1.Text = c.GetMax().Rows[0][0].ToString();

                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = c.Get_All_Customer();
            }
            else
            {
                textBox1.Text = c.maxcomp().Rows[0][0].ToString();

            }
         
     
           

          
      


           
            

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("You Cant do anything if the boxes are empty  ", "Warning  ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {

                if (label8.Text == "Manage Customer")
                {
                    c.AddCustomer(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox4.Text, textBox3.Text, Convert.ToInt32("2"));
                    MessageBox.Show("Add Seccess", "Add Product ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dataGridView1.DataSource = c.Get_All_Customer();

                }
                else
                {
                    c.AddCustomer(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox4.Text, textBox3.Text, Convert.ToInt32("1"));
                    MessageBox.Show("Add Seccess", "Add Product ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dataGridView1.DataSource = c.Get_All_Company();

                }

            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            
                if (MessageBox.Show("Do you realy want to delete this Product ?", "Delete Product", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    c.Delete_Customer(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value));
                    MessageBox.Show("Delete successful", "Delete Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (label8.Text == "Manage Customer")
                    {
                        this.dataGridView1.DataSource = c.Get_All_Customer();
                    }
                    else
                    {
                        this.dataGridView1.DataSource = c.Get_All_Company();
                    }


                }
                else
                {
                    MessageBox.Show("Delete Cancled", "Delete Product", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("You Cant do anything if the boxes are empty  ", "Warning  ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                if (label8.Text == "Manage Customer")
                {
                    c.UpdateCustomer(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox4.Text, textBox3.Text, Convert.ToInt32("2"));
                    MessageBox.Show("Update Seccess", "Update Product ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dataGridView1.DataSource = c.Get_All_Customer();

                }
                else
                {
                    c.UpdateCustomer(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox4.Text, textBox3.Text, Convert.ToInt32("1"));
                    MessageBox.Show("Update Seccess", "Update Product ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dataGridView1.DataSource = c.Get_All_Company();

                }

            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells[0].Value);
            textBox2.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells[1].Value);
            textBox4.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells[2].Value);
            textBox3.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells[3].Value);
        }

        private void textBox1_AcceptsTabChanged(object sender, EventArgs e)
        {
            
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                textBox4.Focus();
            }
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                textBox3.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {


            if (label8.Text == "Manage Customer")
            {
                textBox1.Text = c.GetMax().Rows[0][0].ToString();

                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();

              
            }
            else
            {
                textBox1.Text = c.maxcomp().Rows[0][0].ToString();


                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
           


            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }
    

        

        private void label3_Validated(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
               
            }
        }


    }
}
