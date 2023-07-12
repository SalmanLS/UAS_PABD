using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
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
        private string namaT, jns, lama,idt;
        private int hrga;
        private DateTime tgl;
        private double total;
        private void refreshform()
        {
            cbxNama.Enabled = false;
            cbxJnsvilla.Enabled = false;
            txtLm.Visible = false;
            cbxNama.SelectedIndex = -1;
            cbxJnsvilla.SelectedIndex = -1;
            btnSave.Enabled = false;
            btnClear.Enabled = false;
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
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
            btnClear.Enabled = true;
            btnAdd.Enabled = true;
            btnSave.Enabled = true;
            btnUpdate.Enabled=true;
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

        private void label5_Click(object sender, EventArgs e)
        {

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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string queryString = "Update dbo.Reservasi set no_villa='" + cbxJnsvilla.Text 
                + "', lamaSewa='" + txtLm.Text
                + "' where id_tamu='" + cbxNama.Text + "'";
            
            SqlCommand cmd = new SqlCommand(queryString, koneksi);
            try
            {
                koneksi.Open();
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                koneksi.Close();
                MessageBox.Show("Update Data Berhasil");
                refreshform();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Terdapat sebuah error : " + ex.Message + "(Error code : " + ex.Number + ")");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Halaman_Utama hu = new Halaman_Utama(); 
            hu.Show();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            namaT = cbxNama.Text;
            jns = cbxJnsvilla.Text;
            lama = txtLm.Text;
            tgl = dtRsv.Value;
            string pkt = "";
            int jnsV = 0;
            int hrg = 0;
            koneksi.Open();
            string strr = "select id_tamu from dbo.Tamu where namaTamu = @ds";
            SqlCommand cm = new SqlCommand(strr, koneksi);
            cm.CommandType = CommandType.Text;
            cm.Parameters.Add(new SqlParameter("@ds", namaT));
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                pkt = dr["id_tamu"].ToString();
            }
            dr.Close();
            string strs = "select kode_jenisVilla from dbo.Jenis_Villa where jenisVilla = @dv";
            SqlCommand cms = new SqlCommand(strs, koneksi);
            cms.CommandType = CommandType.Text;
            cms.Parameters.Add(new SqlParameter("@dv", jns));
            SqlDataReader d = cms.ExecuteReader();
            while (d.Read())
            {
                jnsV = int.Parse(d["kode_jenisVilla"].ToString());
            }
            d.Close();
            string strt = "select harga from dbo.Villa where kode_jenisVilla = @dd";
            SqlCommand cmdd = new SqlCommand(strt, koneksi);
            cmdd.CommandType = CommandType.Text;
            cmdd.Parameters.Add(new SqlParameter("@dd", jnsV));
            SqlDataReader l = cmdd.ExecuteReader();
            while (l.Read())
            {
                hrg = int.Parse(l["harga"].ToString());
            }
            l.Close();
            totalHarga(hrg);
            string st = "insert into dbo.Reservasi(tgl_reservasi, id_tamu, no_villa, lamaSewa, totalHarga)"+
                "values(@tg,@id,@nv,@ls,@th)";
            SqlCommand cmd = new SqlCommand(st, koneksi);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("tg", tgl));
            cmd.Parameters.Add(new SqlParameter("id", pkt));
            cmd.Parameters.Add(new SqlParameter("nv", jnsV));
            cmd.Parameters.Add(new SqlParameter("ls", lama));
            cmd.Parameters.Add(new SqlParameter("th", total));
            cmd.ExecuteNonQuery();

            koneksi.Close();

            MessageBox.Show("Reservasi Berhasil! "+"\nTotal Harga = " + "Rp. " + total,"Sukses",MessageBoxButtons.OK, MessageBoxIcon.Information);
            refreshform();
        }

        private double totalHarga(int harga)
        {
            lama = txtLm.Text;
            int lm = int.Parse(lama);
            total = lm*harga;
            return total;
        }
        
    }
}
