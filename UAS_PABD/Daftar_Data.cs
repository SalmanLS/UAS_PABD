using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UAS_PABD
{
    public partial class Daftar_Data : Form
    {
        public Daftar_Data()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Halaman_Utama hu = new Halaman_Utama();
            hu.Show();
            this.Hide();
        }

        private void Daftar_Data_Load(object sender, EventArgs e)
        {

        }

        private void btnTamu_Click(object sender, EventArgs e)
        {
            Daftar_Tamu du = new Daftar_Tamu();
            du.Show();
            this.Hide();
        }

        private void btnRsv_Click(object sender, EventArgs e)
        {
            Daftar_Reservasi dr = new Daftar_Reservasi();
            dr.Show();
            this.Hide();
        }

        private void btnCtr_Click(object sender, EventArgs e)
        {
            Daftar_Katering dk = new Daftar_Katering();
            dk.Show();
            this.Hide();
        }
    }
}
