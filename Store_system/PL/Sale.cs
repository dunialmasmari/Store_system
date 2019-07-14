using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Store_system.PL
{
    public partial class Sale : Form
    {
        BL.clsInvoice inv = new BL.clsInvoice();
        DataTable dt = new DataTable();
        DateTime d;

        string s;
        void calculatetotal()
        {
            if (txtprice.Text != string.Empty && txtqty.Text != string.Empty)
            {
                lbltotal.Text = (Convert.ToDouble(txtprice.Text) * Convert.ToInt32(txtqty.Text)).ToString();
            }

        }
        void CreateDataTable()
        {
            dt.Columns.Add("ID");
            dt.Columns.Add("Item Name");
            dt.Columns.Add("Quantity");
            dt.Columns.Add("Price");
            dt.Columns.Add("Expiry Date");
            dt.Columns.Add("Total Price");
            dataGridView1.DataSource = dt;


        }

        
        void ClearBoxes()
        {
            txtitem.Clear();
            txtqty.Clear();
            txtprice.Clear();
            button1.Focus();
            
        }
            
        public Sale()
        {
            InitializeComponent();
            textBox5.Text = Program.empname;
            CreateDataTable();

            comboBox1.DataSource = inv.Get_All_Customer();
            comboBox1.DisplayMember = "cocuname";
            comboBox1.ValueMember = "cocuno";

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Sale_Load(object sender, EventArgs e)
        {
            this.textBox1.Text = inv.maxsale().Rows[0][0].ToString();
            

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = inv.maxsale().Rows[0][0].ToString();

            ClearBoxes();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           stockitem f = new stockitem();

            f.ShowDialog();

            txtitem.Text = f.dataGridView1.CurrentRow.Cells[1].Value.ToString();
           
            s = f.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtprice.Text = f.dataGridView1.CurrentRow.Cells[2].Value.ToString();
          //  d=Convert.ToDateTime(f.dataGridView1.CurrentRow.Cells[4].Value);
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            char decimalseparator = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != decimalseparator)
            {

                e.Handled = true;
            }
            
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtprice_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void txtqty_KeyDown(object sender, KeyEventArgs e)
        {
             if (e.KeyCode==Keys.Enter)
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1;i++ )
                {
                    if (dataGridView1.Rows[i].Cells[0].Value.ToString()==s)
                    {
                        MessageBox.Show("this product already added", "Worning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
                DataRow r = dt.NewRow();
                r[0] = s;
                r[1] = txtitem.Text;
                r[2] = txtqty.Text;
                r[3] = txtprice.Text;
                r[4] = d;
                r[5] = lbltotal.Text;
                dt.Rows.Add(r);

                dataGridView1.DataSource = dt;
                ClearBoxes();


                textBox3.Text = (from DataGridViewRow row in dataGridView1.Rows
                                     where row.Cells[5].FormattedValue.ToString() != string.Empty
                                     select Convert.ToDouble(row.Cells[5].FormattedValue)).Sum().ToString();
            }
        }
            
            
        

        private void txtprice_KeyUp(object sender, KeyEventArgs e)
        {
          

        }

        private void txtqty_KeyUp(object sender, KeyEventArgs e)
        {
            calculatetotal();

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                s = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                txtitem.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtqty.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtprice.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[4].Value);
                lbltotal.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                txtqty.Focus();

            }
            catch
            {
                return;
            }
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            textBox3.Text = (from DataGridViewRow row in dataGridView1.Rows
                                 where row.Cells[5].FormattedValue.ToString() != string.Empty
                                 select Convert.ToDouble(row.Cells[5].FormattedValue)).Sum().ToString();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1_DoubleClick(sender, e);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);

        }

        private void deleteAllToolStripMenuItem_Click(object sender, EventArgs e)
        {

            dt.Clear();
            dataGridView1.Refresh();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("You Cant do anything if the boxes are empty  ", "Warning  ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                inv.AddInvoice(Convert.ToInt32(textBox1.Text), dateTimePicker1.Value, 1, Program.empno, Convert.ToInt32(comboBox1.SelectedValue), textBox3.Text);


                    for (int i = 0; i < dataGridView1.Rows.Count - 1;i++ )
                   {
                       string max = inv.invoicedetailsmax().Rows[0][0].ToString();
                      

                       inv.AddInvoiceDetails(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value), Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value),Convert.ToString("Null"),
                         dataGridView1.Rows[i].Cells[4].Value.ToString(), Convert.ToString(dataGridView1.Rows[i].Cells[3].Value),
                          Convert.ToString("0.15"), dataGridView1.Rows[i].Cells[5].Value.ToString(), Convert.ToInt32(textBox1.Text));



                    
                 }


                MessageBox.Show("Add Seccess", "Add Product ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textBox1.Clear();
                dataGridView1.DataSource = dt;
                txtqty.Clear();
                lbltotal.Text = "";
                textBox3.Clear();

            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (Char.IsDigit(ch) && ch != 8 )
            {

                e.Handled = true;
            }
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
