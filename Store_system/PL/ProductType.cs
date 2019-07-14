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
    public partial class ProductType : Form
    {
        BL.clssetting s = new BL.clssetting();
        public ProductType()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Do you realy want to delete this Product ?", "Delete Product", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                s.DeleteItemType(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value));
                MessageBox.Show("Delete successful", "Delete Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = s.Get_All_Type();


            }
            else
            {
                MessageBox.Show("Delete Cancled", "Delete Product", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ProductType_Load(object sender, EventArgs e)
        {
            textBox1.Text = s.maxitemtype().Rows[0][0].ToString();

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = s.Get_All_Type();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = s.maxitemtype().Rows[0][0].ToString();

            textBox2.Clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("You Cant do anything if the boxes are empty  ", "Warning  ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                s.AddType(Convert.ToInt32(textBox1.Text), textBox2.Text);
                MessageBox.Show("Add Seccess", "Add Product ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = s.Get_All_Type();



                textBox2.Clear();

                textBox1.Text = s.maxitemtype().Rows[0][0].ToString();

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("You Cant do anything if the boxes are empty  ", "Warning  ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                s.UpdateType(Convert.ToInt32(textBox1.Text), textBox2.Text);

                MessageBox.Show("Update Seccess", "Update Product ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dataGridView1.DataSource = s.Get_All_Type();



                textBox2.Clear();

                textBox1.Text = s.maxitemtype().Rows[0][0].ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
