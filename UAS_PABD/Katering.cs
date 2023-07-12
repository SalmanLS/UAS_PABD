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
    public partial class Katering : Form
    {
        private string stringConnection = "data source=LUTHFI\\MCH35;"+
           "database=Villa;User ID=sa; Password=12345";
        private SqlConnection koneksi;
        private string jk, nm, hari, prs,hrg;
        private DateTime tgl;
        private double total;
        public Katering()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }

        private void refreshform()
        {
            cbxJk.Enabled = false;
            txtHrga.Enabled= false;
            txtHari.Enabled = false;
            dtTanggal.Enabled = false;
            cbxNama.Enabled = false;
            txtPorsi.Enabled = false;
            btnAdd.Enabled = true;
            btnClear.Enabled = false;
            btnSave.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void Katering_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Halaman_Utama hu = new Halaman_Utama();
            hu.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cbxJk.Enabled = true;
            txtHrga.Enabled= true;
            txtHari.Enabled = true;
            dtTanggal.Enabled = true;
            cbxNama.Enabled = true;
            txtPorsi.Enabled = true;
            btnAdd.Enabled = false;
            btnClear.Enabled = true;
            btnSave.Enabled = true;
            btnUpdate.Enabled = true;
            jenisKcbx();
            Namatcbx();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void jenisKcbx()
        {
            koneksi.Open();
            string str = "select jenisKatering from dbo.Jenis_Katering";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteReader();
            koneksi.Close();
            cbxJk.DisplayMember = "jenisKatering";
            cbxJk.ValueMember = "kode_jenisKatering";
            cbxJk.DataSource = ds.Tables[0];
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            koneksi.Open();
            int harga = int.Parse(txtHrga.Text);
            totalHarga(hrg, txtPorsi.Text, txtHari.Text);
            string queryString = "Update dbo.Katering set kode_jenisKatering ='" + cbxJk.Text
                + "', hari='" + txtHari.Text + "', tanggal='" + dtTanggal.Value + "', tanggal='" + harga
                + "' where id_katering='" + cbxNama.Text + "'";
            string qs = "Update dbo.Pemesanan set tgl_pemesanan ='" + dtTanggal.Value
                + "', porsi='" + txtPorsi.Text + "', totalHarga='" + total
                + "' where id_tamu='" + cbxNama.Text + "'";

            SqlCommand cmd = new SqlCommand(queryString, koneksi);
            SqlCommand cmds = new SqlCommand(qs, koneksi);

            try
            {
                
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                cmds.CommandType = CommandType.Text;
                cmds.ExecuteNonQuery();
                koneksi.Close();
                MessageBox.Show("Update Data Berhasil");
                refreshform();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Terdapat sebuah error : " + ex.Message + "(Error code : " + ex.Number + ")");
            }
        }

        private void Namatcbx()
        {
            koneksi.Open();
            string str = "select namaTamu from dbo.Tamu";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteReader();
            koneksi.Close();
            cbxNama.DisplayMember = "namaTamu";
            cbxNama.ValueMember = "id_tamu";
            cbxNama.DataSource = ds.Tables[0];
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            jk = cbxJk.Text;
            nm = cbxNama.Text;
            hari = txtHari.Text;
            tgl = dtTanggal.Value;
            hrg = txtHrga.Text;
            prs = txtPorsi.Text;
            int jkr = 0;
            string idt = "";
            int idk = 0;
            koneksi.Open();
            string strr = "select kode_jenisKatering from dbo.Jenis_Katering where jenisKatering = @ds";
            SqlCommand cm = new SqlCommand(strr, koneksi);
            cm.CommandType = CommandType.Text;
            cm.Parameters.Add(new SqlParameter("@ds", jk));
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                jkr = int.Parse(dr["kode_jenisKatering"].ToString());
            }
            dr.Close();
            string strs = "select id_tamu from dbo.Tamu where namaTamu = @d";
            SqlCommand cmd = new SqlCommand(strs, koneksi);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("@d", nm));
            SqlDataReader d = cmd.ExecuteReader();
            while (d.Read())
            {
                idt = d["id_tamu"].ToString();
            }
            d.Close();
            int harga = int.Parse(hrg);
            string st = "insert into dbo.Katering(kode_jenisKatering,hargaKatering,hari,tanggal)"
                +"values(@kjk,@hk,@h,@t)";
            SqlCommand sc = new SqlCommand(st, koneksi);
            sc.CommandType = CommandType.Text;
            sc.Parameters.Add(new SqlParameter("kjk",jkr));
            sc.Parameters.Add(new SqlParameter("hk", harga));
            sc.Parameters.Add(new SqlParameter("h",hari ));
            sc.Parameters.Add(new SqlParameter("t", tgl));
            sc.ExecuteNonQuery();
            string ste = "select id_katering from dbo.Katering where kode_jenisKatering = @ds";
            SqlCommand cms = new SqlCommand(ste, koneksi);
            cms.CommandType = CommandType.Text;
            cms.Parameters.Add(new SqlParameter("@ds", jkr));
            SqlDataReader rd = cms.ExecuteReader();
            while (rd.Read())
            {
                idk = int.Parse(rd["id_katering"].ToString());
            }
            rd.Close();
            totalHarga(hrg,prs,hari);
            string sg = "insert into dbo.Pemesanan(tgl_pemesanan, id_tamu, id_katering, porsi, totalHarga)"
                +"values(@tg,@idt,@idk,@p,@th)";
            SqlCommand sd = new SqlCommand(sg, koneksi);
            sd.CommandType = CommandType.Text;
            sd.Parameters.Add(new SqlParameter("tg",tgl));
            sd.Parameters.Add(new SqlParameter("idt", idt));
            sd.Parameters.Add(new SqlParameter("idk",idk));
            sd.Parameters.Add(new SqlParameter("p",prs));
            sd.Parameters.Add(new SqlParameter("th",total));
            sd.ExecuteNonQuery();

            koneksi.Close();
            MessageBox.Show("Pesanan Berhasil! "+"\nTotal Harga = " + "Rp. " + total, "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            refreshform();
        }

        private double totalHarga(string harga, string porsi,string hari)
        {
            int hrg = int.Parse (harga);
            int prs = int.Parse (porsi);
            int hr = int.Parse (hari);
            total = (hrg*prs)*hr;
            return total;
        }
    }
}
