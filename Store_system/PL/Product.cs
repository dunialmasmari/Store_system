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
    public partial class Product : Form
    {
            
    
      
        BL.clsproduct prd = new BL.clsproduct();
        
        public Product()
        {
            InitializeComponent();
            cmbCategory.DataSource = prd.Get_All_Categorys();
            cmbCategory.DisplayMember = "categoryname";
            cmbCategory.ValueMember = "categoryno";
            cmbtype.DataSource = prd.Get_All_Type();
            cmbtype.DisplayMember = "item_typename";
            cmbtype.ValueMember = "item_typeno";
            cmbcomp.DataSource = prd.Get_All_Company();
            cmbcomp.DisplayMember = "cocuname";
            cmbcomp.ValueMember = "cocuno";
    

         
        }

        private void Product_Load(object sender, EventArgs e)
        { 
            txtid.Text = prd.Max_Productno().Rows[0][0].ToString();
          this.dataGridView1.AutoGenerateColumns = false;
           this.dataGridView1.DataSource = prd.Get_All_Product();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "" || txtname.Text == "" || txtmin.Text == "" || txtmax.Text == "")
            {
                MessageBox.Show("You Cant do anything if the boxes are empty  ", "Warning  ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {

                prd.Add_Product(Convert.ToInt32(txtid.Text), txtname.Text, Convert.ToInt32(txtmin.Text), Convert.ToInt32(txtmax.Text), Convert.ToInt32(cmbtype.SelectedValue), Convert.ToInt32(cmbCategory.SelectedValue), Convert.ToInt32(cmbcomp.SelectedValue));
                MessageBox.Show("Add Seccess", "Add Product ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dataGridView1.DataSource = prd.Get_All_Product();
                txtid.Text = prd.Max_Productno().Rows[0][0].ToString();

                txtname.Clear();
                txtmin.Clear();
                txtmax.Clear();
            }
          
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {
            if (txtname.Text != "")
            {


                DataTable Dt = new DataTable();
                Dt = prd.Name_Product(txtname.Text);
                this.dataGridView1.DataSource = Dt;
            }
            else
                this.dataGridView1.DataSource = prd.Get_All_Product();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
          
             if( MessageBox.Show("Do you realy want to delete this Product ?","Delete Product",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation)==DialogResult.Yes)
            {
                prd.Delete_Product(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value));
                MessageBox.Show("Delete successful", "Delete Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dataGridView1.DataSource = prd.Get_All_Product();

                
            }
            else
            {
                MessageBox.Show("Delete Cancled", "Delete Product", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {


            if (txtid.Text == "" || txtname.Text == "" || txtmin.Text == "" || txtmax.Text == "")
            {
                MessageBox.Show("You Cant do anything if the boxes are empty  ", "Warning  ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
            prd.Update_Product(
           Convert.ToInt32(txtid.Text), txtname.Text, Convert.ToInt32(txtmin.Text), Convert.ToInt32(txtmax.Text), Convert.ToInt32(cmbtype.SelectedValue), Convert.ToInt32(cmbCategory.SelectedValue), Convert.ToInt32(cmbcomp.SelectedValue));
            MessageBox.Show("Update Seccess", "Update Product ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.dataGridView1.DataSource = prd.Get_All_Product();
            txtid.Text = prd.Max_Productno().Rows[0][0].ToString();

            txtname.Clear();
            txtmin.Clear();
            txtmax.Clear();

        } 
        
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtid.Text = prd.Max_Productno().Rows[0][0].ToString();
            
            txtname.Clear();
            txtmin.Clear();
            txtmax.Clear();
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtid_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (Char.IsDigit(ch) && ch != 8)
            {

                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                txtmin.Focus();
            }
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbcomp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbtype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtmax_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmin_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

           
            
        }

        private void txtmin_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {

                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                txtmax.Focus();
            }
        }

        private void txtmax_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtmax_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {

                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                BtnAdd.Focus();
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            txtid.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells[0].Value);
            txtname.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells[1].Value);
            txtmin.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells[2].Value);
            txtmax.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells[3].Value);
            cmbtype.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells[4].Value);

            cmbCategory.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells[5].Value);

            cmbcomp.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells[6].Value);


        }
    }
}
