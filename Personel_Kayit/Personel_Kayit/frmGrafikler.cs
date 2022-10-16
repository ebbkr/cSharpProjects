using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Personel_Kayit
{
    public partial class frmGrafikler : Form
    {
        public frmGrafikler()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-69DNETM\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
       
        private void frmGrafikler_Load(object sender, EventArgs e)
        {
            // Sehirler Grafiği
            baglanti.Open();
            SqlCommand komutg1 = new SqlCommand("Select PersSehir,Count(*) From Table_1 Group by PersSehir",baglanti);
            SqlDataReader drg1 = komutg1.ExecuteReader();

            while (drg1.Read())
            {
                chart1.Series["Sehirler"].Points.AddXY(drg1[0], drg1[1]);
            }
            baglanti.Close();

            // Meslek-Maaş Grafiği
            baglanti.Open();
            SqlCommand komutg2 = new SqlCommand("Select PersMeslek,Avg(PersMaas) From Table_1 Group by PersMeslek", baglanti);
            SqlDataReader drg2 = komutg2.ExecuteReader();

            while (drg2.Read())
            {
                chart2.Series["Maaslar"].Points.AddXY(drg2[0], drg2[1]);
            }
            baglanti.Close();

        }
    }
}
