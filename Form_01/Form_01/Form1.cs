using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblMesaj.Text = "";
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            lblMesaj.Text = "Hoşgeldin " + txtAdSoyad.Text;
        }

        private void txtAdSoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblMesaj_Click(object sender, EventArgs e)
        {

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAdSoyad.Text = "";
            lblMesaj.Text = "";

        }
    }
}
