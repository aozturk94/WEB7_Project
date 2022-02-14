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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        string CinsiyetBelirle()
        {
            if (rdbKadin.Checked==true)
            {
                return "Kadın";
            }

            else
            {
                return "Erkek";
            }
        }

        void Ekle()
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Text = txtAdSoyad.Text.ToUpper(); //Text, lvi'nin 1. klonu demektir.
            lvi.SubItems.Add(CinsiyetBelirle()); //Daha sonraki klonları bu şekilde belirliyoruz.
            lvi.SubItems.Add("Wissen");
            lswKisiler.Items.Add(lvi); //!Hoca lsv olarak adlandırmış!
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Ekle();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            rdbKadin.Checked = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string aranan = txtAranan.Text.ToUpper();
            //lblMesaj.Text = lswKisiler.Items.Find(aranan, true).ToString();
            //ListViewItem[] lviSonuc = lswKisiler.Items.Find(aranan, true); //True dersek tüm kolonlarda arama yapacak.
            //MessageBox.Show(lviSonuc.Length.ToString());
            //lswKisiler.Clear();
            //lswKisiler.Items.AddRange(lviSonuc); //Son 4 kısım sorunlu!
        }
    }
}
