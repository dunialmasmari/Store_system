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
    public partial class Category : Form
    {
        BL.clssetting s = new BL.clssetting();
       
        public Category()
        {
            InitializeComponent();
            comboBox1.DataSource = s.Get_All_Company();
            comboBox1.DisplayMember = "cocuname";
            comboBox1.ValueMember = "cocuno";
        }

        private void Category_Load(object sender, EventArgs e)
        {
            textBox1.Text = s.maxcat().Rows[0][0].ToString();

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = s.Get_All_Category();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you realy want to delete this Product ?", "Delete Product", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                s.DeleteCategory(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value));
                MessageBox.Show("Delete successful", "Delete Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = s.Get_All_Category();



            }
            else
            {
                MessageBox.Show("Delete Cancled", "Delete Product", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" )
            {
                MessageBox.Show("You Cant do anything if the boxes are empty  ", "Warning  ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                s.AddCategory(Convert.ToInt32(textBox1.Text), textBox2.Text, Convert.ToInt32(comboBox1.SelectedValue));
                MessageBox.Show("Add Seccess", "Add Product ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = s.Get_All_Category();
                textBox2.Clear();
                textBox1.Text = s.maxcat().Rows[0][0].ToString();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("You Cant do anything if the boxes are empty  ", "Warning  ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                s.UpdateCategory(Convert.ToInt32(textBox1.Text), textBox2.Text, Convert.ToInt32(comboBox1.SelectedValue));
                MessageBox.Show("Update Seccess", "Update Product ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dataGridView1.DataSource = s.Get_All_Category();
                textBox2.Clear();
                textBox1.Text = s.maxcat().Rows[0][0].ToString();
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            
            textBox1.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells[0].Value);
            textBox2.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells[1].Value);
            comboBox1.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells[2].Value);



        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox1.Text = s.maxcat().Rows[0][0].ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
