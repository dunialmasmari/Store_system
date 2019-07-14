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
    public partial class stockitem : Form
    {

        public DataTable Get_All_stockitem()
        {
            DAL.DAL DAL = new DAL.DAL();

            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("Get_All_stockitem", null);
            DAL.Close();
            return Dt;


        }
        public stockitem()
        {
            InitializeComponent();
        }

        private void stockitem_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;

            dataGridView1.DataSource = Get_All_stockitem();

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
