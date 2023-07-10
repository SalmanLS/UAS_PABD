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

namespace UAS_PABD
{
    public partial class Daftar_Reservasi : Form
    {
        private string stringConnection = "data source=DESKTOP-NKUDL8D\\DIMASDAMAR;" +
            "database=Villa;User ID=sa; Password=magic118";
        private SqlConnection koneksi;
        public Daftar_Reservasi()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);

        }
        private void dataGridView()
        {
            koneksi.Open();
            string str = "select Reservasi.kode_reservasi,Tamu.id_tamu, Tamu.namaTamu , Reservasi.tgl_reservasi, Reservasi.lamaSewa, Reservasi.no_villa\r\nfrom Reservasi\r\ninner join Tamu on Reservasi.id_tamu = Tamu.id_tamu;";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Daftar_Data dd = new Daftar_Data();
            dd.Show();
            this.Hide();
        }

        private void Daftar_Reservasi_Load(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            dataGridView();
            btnOpen.Enabled = false;
        }
    }
}
