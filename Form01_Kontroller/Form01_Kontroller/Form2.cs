using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form01_Kontroller
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        void Ekle()
        {
            if (!Ara(txtAdSoyad.Text))
            {
                lstKisiler.Items.Add(txtAdSoyad.Text);
                //txtAdSoyad.Text = ""; Alttaki ikisi ile aynı işlevde 
                //txtAdSoyad.Clear(); 
                lblKisiSayisi.Text = lstKisiler.Items.Count.ToString(); //Saydırmak için
            }
            else
            {
                MessageBox.Show("İlgili Kişi Zaten Var!");
            }

            txtAdSoyad.ResetText();
            txtAdSoyad.Focus();//İmlecin sürekli textbox'da kalması için.
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Ekle();
        }

        private void txtAdSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==((char)Keys.Enter)&&txtAdSoyad.Text!="")
            {
                Ekle();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblKisiSayisi.Text = "";
        }
        
        bool Ara(string aranan)
        {

            if (lstKisiler.Items.Contains(aranan)) //Aranan var ise true döndürüyor.
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void btnAra_Click(object sender, EventArgs e)
        {
            if (Ara(txtAranan.Text))
            {
                lblSonuc.Text = txtAranan.Text;

            }
            else
            {
                lblSonuc.Text = "İlgili Kişi Bululamadı!";

            }


        }

        private void lblSonuc_Click(object sender, EventArgs e)
        {

        }
    }
}
