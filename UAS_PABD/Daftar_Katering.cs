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
    public partial class Daftar_Katering : Form
    {
        public Daftar_Katering()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Daftar_Data dd = new Daftar_Data();
            dd.Show();
            this.Hide();
        }
    }
}
