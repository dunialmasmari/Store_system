using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Store_system.PL
{
    
        
    public partial class Purchase : Form
    {
        SqlConnection con = new SqlConnection();

        BL.clsInvoice inv = new BL.clsInvoice();
        DataTable dt = new DataTable();
        string s;
      

       

        void ClearBoxes()
        {
            textBox7.Clear();
            txtqty.Clear();
            txtcost.Clear();
            button4.Focus();
            
        }
     
        void CreateDataTable()
        {
            
            dt.Columns.Add("ID");
            dt.Columns.Add("Item Name");
            dt.Columns.Add("Quantity");
            dt.Columns.Add("Cost");
            dt.Columns.Add("Expiry Date");
            dt.Columns.Add("Total Cost");
            dataGridView1.DataSource = dt;


        }
        public Purchase()
        {
            InitializeComponent();
            CreateDataTable();
          
            textBox5.Text = Program.empname;
            comboBox1.DataSource = inv.Get_All_Company();
            comboBox1.DisplayMember = "cocuname";
            comboBox1.ValueMember = "cocuno";

            
        }
   
        void calculatetotal()
        {
            if (txtcost.Text != string.Empty && txtqty.Text != string.Empty)
            {
                lbltotalcost.Text =( Convert.ToDouble(txtcost.Text) * Convert.ToInt32(txtqty.Text)).ToString();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = inv.maxpurchase().Rows[0][0].ToString();

            ClearBoxes();
            txtsumtotals.Clear();
            lbltotalcost.Text = "";
           
            dataGridView1.DataSource = dt;
            Save.Enabled = true;
            button6.Enabled = false;
            this.simpleButton2.Enabled = false;

        }

        private void Invoice_Load(object sender, EventArgs e)
        {
            this.textBox1.Text = inv.maxpurchase().Rows[0][0].ToString();
        
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClearBoxes();
            Items f = new Items();
            f.ShowDialog();
           textBox7.Text = f.dataGridView2.CurrentRow.Cells[1].Value.ToString();
           s = f.dataGridView2.CurrentRow.Cells[0].Value.ToString();
          
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {

                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                txtcost.Focus();
            }
            
         
           
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            char decimalseparator = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch !=decimalseparator)
            {

                e.Handled = true;
            }
           
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtqty_KeyUp(object sender, KeyEventArgs e)
        {
            calculatetotal();
        }

        private void txtcost_KeyUp(object sender, KeyEventArgs e)
        {
            calculatetotal();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcost_KeyDown(object sender, KeyEventArgs e)
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
                String Date = dateTimePicker2.Value.ToShortDateString();
                DataRow r = dt.NewRow();
                r[0] = s;
                r[1] = textBox7.Text;
                r[2] = txtqty.Text;
                r[3] = txtcost.Text;
                r[4] = Convert.ToString(Date);
                r[5] = lbltotalcost.Text;
                dt.Rows.Add(r);

                dataGridView1.DataSource = dt;
                ClearBoxes();


                txtsumtotals.Text = (from DataGridViewRow row in dataGridView1.Rows
                                     where row.Cells[5].FormattedValue.ToString() != string.Empty
                                     select Convert.ToDouble(row.Cells[5].FormattedValue)).Sum().ToString();
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                s = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                textBox7.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtqty.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtcost.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                 
                dateTimePicker2.Value =Convert.ToDateTime( dataGridView1.CurrentRow.Cells[4].Value);
                lbltotalcost.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
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


            txtsumtotals.Text = (from DataGridViewRow row in dataGridView1.Rows
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

        private void Save_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("You Cant do anything if the boxes are empty  ", "Warning  ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
                if (txtsumtotals.Text != "0")

            {   inv.AddInvoice(Convert.ToInt32(textBox1.Text), dateTimePicker1.Value, 2, Program.empno, Convert.ToInt32(comboBox1.SelectedValue), txtsumtotals.Text);

            for (int i = 0; i < dataGridView1.Rows.Count - 1;i++ )
                   {
                       string precentage = "0.15";
                       
                      double s =Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value.ToString());
                     

                      double Price =s+(s*Convert.ToDouble( precentage));
                 
                    

                    inv.AddInvoiceDetails(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value) ,Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value),
                      Convert.ToString(dataGridView1.Rows[i].Cells[3].Value),dataGridView1.Rows[i].Cells[4].Value.ToString(),Convert.ToString(Price),
                       precentage,dataGridView1.Rows[i].Cells[5].Value.ToString(),Convert.ToInt32(textBox1.Text));
                 }
                    MessageBox.Show("Add Seccess", "Add Product ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  
                  //  ClearBoxes();
                  //  txtsumtotals.Clear();
                 //   lbltotalcost.Text = "";
                 //   dataGridView1.DataSource = dt;
                    this.Save.Enabled = false;
                    button6.Enabled = true;
                    simpleButton2.Enabled = true;
            }
            else
            MessageBox.Show("There Is No Product  Purchase process can not be save   ", "Warning  ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

        }

        private void txtqty_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
          // ClearBoxes();
            Purchase_Management pm = new Purchase_Management();
            pm.ShowDialog();

       //     textBox1.Text = pm.dataGridView1.CurrentRow.Cells[0].Value.ToString();
         //  dateTimePicker1.Text =pm.dataGridView1.CurrentRow.Cells[1].Value.ToString();

           // textBox5.Text = pm.dataGridView1.CurrentRow.Cells[2].Value.ToString();

           //comboBox1.Text = pm.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            //txtsumtotals.Text = pm.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            //dataGridView1.DataSource = inv.Get_All_PurchaseDetails(Convert.ToInt32(pm.dataGridView1.CurrentRow.Cells[0].Value.ToString()));


          
            //this.textBox1.Text = inv.maxpurchase().Rows[0][0].ToString();
        }

        private void toolStripSeparator1_Click(object sender, EventArgs e)
        {

        }

      private void button1_Click(object sender, EventArgs e)
        {
            /* if (textBox1.Text == "" || textBox5.Text == "")
           {
               MessageBox.Show("You Cant do anything if the boxes are empty  ", "Warning  ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

           }
           else
               if (txtsumtotals.Text != "0")
               {
                   inv.UpdateInvoice(Convert.ToInt32(textBox1.Text), dateTimePicker1.Value, 2, Program.empno, Convert.ToInt32(comboBox1.SelectedValue), txtsumtotals.Text);

                   for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                   {
                       string precentage = "0.15";

                       double s = Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value.ToString());


                       double Price = s + (s * Convert.ToDouble(precentage));

                       string max = inv.invoicedetailsmax().Rows[0][0].ToString();

                       inv.UpdateInvoiceDetails(Convert.ToInt32(max), Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value), Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value),
                         Convert.ToString(dataGridView1.Rows[i].Cells[3].Value), dataGridView1.Rows[i].Cells[4].Value.ToString(), Convert.ToString(Price),
                          precentage, dataGridView1.Rows[i].Cells[5].Value.ToString(), Convert.ToInt32(textBox1.Text));
                   }
                   MessageBox.Show("Update Seccess", "Update Product ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   this.textBox1.Text = inv.maxpurchase().Rows[0][0].ToString();
                   ClearBoxes();
                   txtsumtotals.Clear();
                   lbltotalcost.Text = "";
                   dataGridView1.DataSource = dt;
               }
               else
                   MessageBox.Show("There Is No Product  Purchase process can not be save   ", "Warning  ", MessageBoxButtons.OK, MessageBoxIcon.Warning);*/
        }

      private void button5_Click(object sender, EventArgs e)
      {
          if (MessageBox.Show("Do you realy want to delete this Purchase ?", "Delete Purchase", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
          {
              inv.Delete_Purchase(Convert.ToInt32(textBox1.Text));
              MessageBox.Show("Delete successful", "Delete Purchase", MessageBoxButtons.OK, MessageBoxIcon.Information);
          }
          else
          {
              MessageBox.Show("Delete Cancled", "Delete Purchase", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

          }
      }

      private void button6_Click(object sender, EventArgs e)
      {
          con.ConnectionString = " server=THENME-PC;integrated security=true;dataBase=store_system";
          string sql = "SELECT  Storeinvoice.Storeinvoice_no as PurchaseId, Storeinvoice.Storeinvoice_date as PurchaseDate,customercompany.cocuname as CompanyName,employee.empname as EmployeeName, item.item_name as ProductName,invoice_details.invoice_detailsExpirydate as ExpiryDate, invoice_details.invoice_detailsCost UnitCost, invoice_details.invoice_detailsqty Quantity, invoice_details.invoice_detailsqty * CONVERT(int, invoice_details.invoice_detailsCost)  AS Total FROM item INNER JOIN invoice_details ON item.item_no = invoice_details.item_no INNER JOIN customercompany ON item.cucono = customercompany.cocuno INNER JOIN  Storeinvoice ON invoice_details.Storeinvoice_no = Storeinvoice.Storeinvoice_no AND customercompany.cocuno = Storeinvoice.cocuno INNER JOIN employee ON Storeinvoice.empno = employee.empno where  Storeinvoice.Storeinvoice_no=" + dataGridView1.CurrentRow.Cells[0].Value.ToString();

          DataSet1 ds = new DataSet1();
          SqlDataAdapter dad = new SqlDataAdapter(sql, con);
          dad.Fill(ds.Tables["DataTable1"]);
          CrystalReport1 cr = new CrystalReport1();
          cr.SetDataSource(ds.Tables["DataTable1"]);
           PrintDialog p = new PrintDialog();
          if (printDialog1.ShowDialog() == DialogResult.OK)
          {
              cr.PrintOptions.PrinterName = printDialog1.PrinterSettings.PrinterName;
           //   cr.PrintToPrinter(printDialog1.PrinterSettings.Copies, printDialog1.PrinterSettings.Collate, printDialog1.PrinterSettings.FromPage, printDialog1.PrinterSettings.ToPage);
              cr.PrintToPrinter(1, true, 0, 0);
          }
          else
          {
              MessageBox.Show(" Print has been cancled");
          }
          simpleButton2.Enabled = true;
          this.button6.Enabled = false;
          //dataGridView1.Rows.Clear();
          dt.Clear();
          dataGridView1.Refresh();

        //  Form1 f = new Form1(textBox1.Text);
        //  f.Show();
      }
      
    }
}
