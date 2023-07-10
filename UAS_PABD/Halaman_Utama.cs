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
    public partial class Halaman_Utama : Form
    {
        public Halaman_Utama()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tamu tm = new Tamu();
            tm.Show();
            this.Hide();
        }

        private void btnKatering_Click(object sender, EventArgs e)
        {
            Katering kr = new Katering();
            kr.Show();
            this.Hide();
        }

        private void btnReservasi_Click(object sender, EventArgs e)
        {
            Reservasi rs = new Reservasi();
            rs.Show();
            this.Hide();
        }

        private void Halaman_Utama_Load(object sender, EventArgs e)
        {

        }

        private void btndaftar_Click(object sender, EventArgs e)
        {
            Daftar_Data dd = new Daftar_Data();
            dd.Show();
            this.Hide();
        }
    }
}
