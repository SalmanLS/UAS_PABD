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
            txtLm.Visible = false;
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
        
        private void cbxNama_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cbxNama.Enabled = true;
            cbxJnsvilla.Enabled = true;
            txtLm.Visible = true;
            txtHrga.Visible = true;
            btnClear.Enabled = true;
            btnAdd.Enabled = true;
            btnSave.Enabled = true;
            Tamucbx();
            Villacbx();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void Tamucbx()
        {
            koneksi.Open();
            string str = "select namaTamu from dbo.Tamu";
            SqlCommand cmd = new SqlCommand(str,koneksi);
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteReader();
            koneksi.Close();
            cbxNama.DisplayMember = "namaTamu";
            cbxNama.ValueMember = "id_tamu";
            cbxNama.DataSource = ds.Tables[0];
        }

        private void Villacbx()
        {
            koneksi.Open();
            string str = "select Villa.no_villa, Jenis_Villa.jenisVilla\r\nfrom Villa\r\ninner join Jenis_Villa on Villa.kode_jenisVilla = Jenis_Villa.kode_jenisVilla;";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteReader();
            koneksi.Close();
            cbxJnsvilla.DisplayMember = "jenisVilla";
            cbxJnsvilla.ValueMember = "no_villa";
            cbxJnsvilla.DataSource = ds.Tables[0];
        }
    }
}
