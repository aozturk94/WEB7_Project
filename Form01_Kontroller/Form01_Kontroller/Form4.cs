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
    public partial class Form4 : Form
    {

        Random rnd = new Random();
        int sayi = 0;
        int kalan = 1;

        public Form4()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayi = rnd.Next(1, 100);
            lblSayi.Text = sayi.ToString();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            timer1.Start();
            rdbTek.Checked = true;
            lblSonuc.Text = "";
        }

        void KontrolEt()
        {
            if (sayi%2==kalan)
            {
                lblSonuc.Text="BİLDİN!";
                lstKazananlar.Items.Add(sayi);

                if (lstKazananlar.Items.Count==3)
                {
                    lblSonuc.Text = "TEBRİKLER! 3 kez bildin, 100 WissenCoin Kazandın!";     
                }
            }

            else
            {
                lblSonuc.Text="Bu sefer olmadı. :(";
            }
        }
        private void lblSayi_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled==true)
            {
                timer1.Stop();
                KontrolEt();
            }
            else
            {
                timer1.Start();
            }

        }

        private void rdbTek_CheckedChanged(object sender, EventArgs e)
        {
            kalan = 1;
        }

        private void rdbCift_CheckedChanged(object sender, EventArgs e)
        {
            kalan = 0;
        }
    }
}
