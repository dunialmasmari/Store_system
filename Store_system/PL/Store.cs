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
    public partial class Store : Form
    {
        BL.clslogin lg = new BL.clslogin();
        
        public Store()
        {
            InitializeComponent();
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox0.Text = lg.maxstore().Rows[0][0].ToString();
            textBox4.Clear();
        }

        private void Store_Load(object sender, EventArgs e)
        {

            textBox0.Text = lg.maxstore().Rows[0][0].ToString();

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = lg.GetAllStore();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("You Cant do anything if the boxes are empty  ", "Warning  ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                lg.AddStore(Convert.ToInt32(textBox0.Text), textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
                MessageBox.Show("Add Seccess", "Add Product ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = lg.GetAllStore();



                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox0.Text = lg.maxstore().Rows[0][0].ToString();
                textBox4.Clear();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("You Cant do anything if the boxes are empty  ", "Warning  ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                lg.UpdateStore(Convert.ToInt32(textBox0.Text), textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
                MessageBox.Show("Update Seccess", "Update Product ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dataGridView1.DataSource = lg.GetAllStore();



                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox0.Text = lg.maxstore().Rows[0][0].ToString();
                textBox4.Clear();
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            textBox0.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells[0].Value);
            textBox1.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells[1].Value);
            textBox2.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells[2].Value);
            textBox3.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells[3].Value);
            textBox4.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells[4].Value);
           
        }

        private void btndelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Do you realy want to delete this Product ?", "Delete Product", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                lg.DeleteStore(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value));
                MessageBox.Show("Delete successful", "Delete Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = lg.GetAllStore();



            }
            else
            {
                MessageBox.Show("Delete Cancled", "Delete Product", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

    }
}
