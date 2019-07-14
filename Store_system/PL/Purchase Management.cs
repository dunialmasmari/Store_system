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

namespace Store_system.PL
{
    public partial class Purchase_Management : Form
    {
        SqlConnection con = new SqlConnection();

        BL.clsInvoice s = new BL.clsInvoice();

        public Purchase_Management()
        {
            InitializeComponent();
        }
     

        private void Purchase_Management_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = s.Get_All_Purchase();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you realy want to delete this Purchase ?", "Delete Purchase", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                s.Delete_Purchase(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value));
                MessageBox.Show("Delete successful", "Delete Purchase", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = s.Get_All_Purchase();



            }
            else
            {
                MessageBox.Show("Delete Cancled", "Delete Purchase", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void deleteSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
           
            if (MessageBox.Show("Do you realy want to delete this Purchase ?", "Delete Purchase", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {

                for (int i = 0; i < dataGridView1.SelectedRows.Count- 1; i++)
                {
                    s.Delete_Purchase(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value));
                    
              

                }

                MessageBox.Show("Delete successful", "Delete Purchase", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = s.Get_All_Purchase();
            }
            else
            {
                MessageBox.Show("Delete Cancled", "Delete Purchase", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {



            Form1 f = new Form1(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            f.Show();
            
          



        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
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
        }
    }
}
