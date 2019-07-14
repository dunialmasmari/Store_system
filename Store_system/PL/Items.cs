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
    public partial class Items : Form
    {
        BL.clsproduct prd = new BL.clsproduct();

        public Items()
        {
            InitializeComponent();
        }

        private void Items_Load(object sender, EventArgs e)
        {
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.DataSource = prd.Get_All_Product();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

            Close();

           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
