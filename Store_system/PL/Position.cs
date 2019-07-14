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
    public partial class Position : Form
    {
        BL.clssetting s = new BL.clssetting();

        public Position()
        {
            InitializeComponent();
        }

        private void Position_Load(object sender, EventArgs e)
        {
            textBox1.Text = s.maxposition().Rows[0][0].ToString();

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = s.Get_All_Position();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = s.maxposition().Rows[0][0].ToString();

            textBox2.Clear();
            textBox3.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Do you realy want to delete this Product ?", "Delete Product", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                s.DeletePosition(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value));
                MessageBox.Show("Delete successful", "Delete Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = s.Get_All_Position();


            }
            else
            {
                MessageBox.Show("Delete Cancled", "Delete Product", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == ""|| textBox3.Text=="")
            {
                MessageBox.Show("You Cant do anything if the boxes are empty  ", "Warning  ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                s.AddPosition(Convert.ToInt32(textBox1.Text), textBox2.Text,Convert.ToDouble(textBox3.Text));
                MessageBox.Show("Add Seccess", "Add Product ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = s.Get_All_Position();



                textBox2.Clear();
                textBox3.Clear();

                textBox1.Text = s.maxposition().Rows[0][0].ToString();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")

            {
                MessageBox.Show("You Cant do anything if the boxes are empty  ", "Warning  ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                s.UpdatePosition(Convert.ToInt32(textBox1.Text), textBox2.Text, Convert.ToDouble(textBox3.Text));


                MessageBox.Show("Update Seccess", "Update Product ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dataGridView1.DataSource = s.Get_All_Position();



                textBox2.Clear();
                textBox3.Clear();
                textBox1.Text = s.maxposition().Rows[0][0].ToString();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
