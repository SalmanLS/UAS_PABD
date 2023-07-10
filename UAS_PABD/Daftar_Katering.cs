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
    public partial class Daftar_Katering : Form
    {
        private string stringConnection = "data source=LUTHFI\\MCH35;" +
           "database=Villa;User ID=sa; Password=12345";
        private SqlConnection koneksi;
        public Daftar_Katering()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);

        }
        private void dataGridView()
        {
            koneksi.Open();
            string str = "select Katering.id_katering, Jenis_Katering.jenisKatering, Tamu.namaTamu, Reservasi.no_villa , Pemesanan.porsi, Pemesanan.totalHarga,Katering.hari, Pemesanan.tgl_pemesanan\r\nfrom Katering\r\ninner join Jenis_Katering on Katering.kode_jenisKatering = Jenis_Katering.kode_jenisKatering\r\ninner join Pemesanan on Katering.id_katering = Pemesanan.id_katering\r\ninner join Tamu on Tamu.id_tamu = Pemesanan.id_tamu\r\ninner join Reservasi on Reservasi.id_tamu = Pemesanan.id_tamu;";
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

        private void Daftar_Katering_Load(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            dataGridView();
            btnOpen.Enabled = false;
        }
    }
}
