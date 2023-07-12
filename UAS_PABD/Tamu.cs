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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UAS_PABD
{
    public partial class Tamu : Form
    {
        private string stringConnection = "data source=LUTHFI\\MCH35;" +
           "database=Villa;User ID=sa; Password=12345";
        private SqlConnection koneksi;
        private string nama, jk, notlfon, noktp,jln,kcmtn,kabupaten,krywn;
        private DateTime tgl;

        private void cbxKrywn_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Halaman_Utama hu = new Halaman_Utama();
            hu.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            string queryString = "Update dbo.Tamu set namaTamu='" + txtNama.Text + "', no_telfon='" + txtTlfn.Text + 
                "', jenisKelamin='" + txtJk.Text + "', jalan='" + txtJln.Text + "', kecamatan='" + txtKcmtn.Text + "', kabupaten='" + txtKbptn.Text 
                + "' where id_tamu='" + txtID.Text + "'";
            string qs = "Update dbo.Data_Tamu set id_karyawan='" + cbxKrywn.Text +
                "' where id_tamu='" + txtID.Text + "'";
            SqlCommand cmd = new SqlCommand(queryString, koneksi);
            SqlCommand cmds = new SqlCommand(qs, koneksi);
            try
            {
                koneksi.Open();
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                cmds.CommandType = CommandType.Text;
                cmds.ExecuteNonQuery();
                koneksi.Close();
                MessageBox.Show("Update Data Berhasil");
                refreshform();
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Terdapat sebuah error : " + ex.Message + "(Error code : " + ex.Number + ")");
            }
            
        }

        private void Tamu_Load(object sender, EventArgs e)
        {

        }

        private void refreshform()
        {
            txtID.Text = "";
            txtJk.Text = "";
            txtJln.Text = "";
            txtKbptn.Text = "";
            txtKcmtn.Text = "";
            txtNama.Text = "";
            txtTlfn.Text = "";
            dtTanggal.Text ="";
            cbxKrywn.Text ="";
            txtID.Enabled = false;
            txtJk.Enabled = false;
            txtJln.Enabled = false;
            txtKbptn.Enabled = false;
            txtKcmtn.Enabled = false;
            txtNama.Enabled = false;
            txtTlfn.Enabled = false;
            cbxKrywn.Enabled= false;
            dtTanggal.Enabled = false;
            btnSave.Enabled = false;
            btnClear.Enabled = false;
            btnUpdate.Enabled = false;
        }
        public Tamu()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtID.Enabled = true;
            txtJk.Enabled = true;
            txtJln.Enabled = true;
            txtKbptn.Enabled = true;
            txtKcmtn.Enabled = true;
            txtNama.Enabled = true;
            txtTlfn.Enabled = true;
            cbxKrywn.Enabled= true;
            dtTanggal.Enabled = true;
            btnSave.Enabled = true;
            btnClear.Enabled = true;
            btnUpdate.Enabled = true;
            Karyawancbx();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void Karyawancbx()
        {
            koneksi.Open();
            string str = "select namaKaryawan from dbo.Karyawan";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteReader();
            koneksi.Close();
            cbxKrywn.DisplayMember = "namaKaryawan";
            cbxKrywn.ValueMember = "id_karyawan";
            cbxKrywn.DataSource = ds.Tables[0];
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            tgl = dtTanggal.Value;
            nama = txtNama.Text;
            noktp = txtID.Text;  
            jk = txtJk.Text;
            notlfon = txtTlfn.Text;
            jln = txtJln.Text;
            kcmtn = txtKcmtn.Text;
            kabupaten = txtKbptn.Text;
            krywn = cbxKrywn.Text;
            int pk = 0;
            koneksi.Open();
            string strr = "select id_karyawan from dbo.Karyawan where namaKaryawan = @dd";
            SqlCommand cm = new SqlCommand(strr, koneksi);
            cm.CommandType = CommandType.Text;
            cm.Parameters.Add(new SqlParameter("@dd", krywn ));
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                pk = int.Parse(dr["id_karyawan"].ToString());
            }
            dr.Close();
            string strs = "insert into dbo.Tamu (id_tamu,namaTamu,no_telfon,jenisKelamin,jalan,kecamatan,kabupaten)"+
                "values(@id,@nm,@notlfn,@jk,@jln,@kcmt,@kbptn)";
            SqlCommand cmd = new SqlCommand(strs,koneksi);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("id",noktp));
            cmd.Parameters.Add(new SqlParameter("nm",nama));
            cmd.Parameters.Add(new SqlParameter("notlfn",notlfon));
            cmd.Parameters.Add(new SqlParameter("jk",jk));
            cmd.Parameters.Add(new SqlParameter("jln",jln));
            cmd.Parameters.Add(new SqlParameter("kcmt",kcmtn));
            cmd.Parameters.Add(new SqlParameter("kbptn",kabupaten));
            cmd.ExecuteNonQuery();

            string str = "insert into dbo.Data_Tamu (id_karyawan,id_tamu,tgl_kunjung)"+
                "values(@idk,@idt,@tglk)";
            SqlCommand cmds = new SqlCommand(str, koneksi);
            cmds.CommandType = CommandType.Text;
            cmds.Parameters.Add(new SqlParameter("idk", pk));
            cmds.Parameters.Add(new SqlParameter("idt", noktp));
            cmds.Parameters.Add(new SqlParameter("tglk", tgl));
            cmds.ExecuteNonQuery();

            koneksi.Close();

            MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            refreshform();
        }
    }
}
