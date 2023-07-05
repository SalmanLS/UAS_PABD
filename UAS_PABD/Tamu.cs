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
    public partial class Tamu : Form
    {
        private string stringConnection = "data source=LUTHFI\\MCH35;"+
           "database=Villa;User ID=sa; Password=12345";
        private SqlConnection koneksi;

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
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            refreshform();
        }
    }
}
