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
    public partial class Reservasi : Form
    {
        private string stringConnection = "data source=LUTHFI\\MCH35;" + 
            "database=Villa;User ID=sa; Password=12345";
        private SqlConnection koneksi;
        private void refreshform()
        {
            cbxNama.Enabled = false;
            cbxJnsvilla.Enabled = false;
            txtLm.Enabled = false;
            txtHrga.Visible = false;
            cbxNama.SelectedIndex = -1;
            cbxJnsvilla.SelectedIndex = -1;
            btnSave.Enabled = false;
            btnClear.Enabled = false;
            btnAdd.Enabled = true;
        }
        public Reservasi()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Reservasi_Load(object sender, EventArgs e)
        {

        }
        private void cbNama()
        {
            koneksi.Open();
            string str = "select nama_tamu from dbo.Tamu where\r\nnot EXISTS(select id_status from dbo.status_mahasiswa where\r\nstatus_mahasiswa.nim = mahasiswa.nim)";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteReader();
            koneksi.Close();

            cbxNama.DisplayMember = "nama_tamu";
            cbxNama.ValueMember = "nim";
            cbxNama.DataSource = ds.Tables[0];
        }
        private void cbxNama_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
