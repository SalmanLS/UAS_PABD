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
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            refreshform();
        }
    }
}
