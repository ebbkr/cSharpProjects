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
using System.Data.SqlClient;

namespace Hastane_otomasyonu
{
    public partial class frmRandevuList : Form
    {
        sqlBaglantisi bgl = new sqlBaglantisi();
        public frmRandevuList()
        {
            InitializeComponent();
        }

        private void frmRandevuList_Load(object sender, EventArgs e)
        {

            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * From Table_Randevular", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
        }




    }
}
