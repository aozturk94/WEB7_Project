using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telefon_Rehberi_V2
{
    public partial class FormAnaMenu : Form
    {
        public FormAnaMenu()
        {
            InitializeComponent();
        }

        private void FormAnaMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            FormYeniKayit yeniKayit = new FormYeniKayit();
            yeniKayit.Show();
            this.Hide();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormAnaMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnCikis.PerformClick(); //PerformClick-->> Git btnCikis'a tıkla demek.
        }

        private void btnListeleme_Click(object sender, EventArgs e)
        {
            FormListeleme listeForm = new FormListeleme();
            listeForm.Show();
            this.Hide();
        }
    }
}
