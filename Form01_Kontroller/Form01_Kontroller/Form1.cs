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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtSayi_TextChanged(object sender, EventArgs e)
        {
            //lblKopya.Text = txtSayi.Text;
        }

        private void txtSayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            //lblKopya.Text = e.KeyChar.ToString(); //e paremetresi ile basılan tuşu yakalayabiliyoruz.

            //e.Handled = false; //Default hali
            //e.Handled = true; //Karakter basmayı engelliyor. Veri girişini değil. true ise engeller.

            //if (e.KeyChar.ToString()=="E")
            //{
            //    e.Handled=false; //Girişe izin ver.
            //}

            //else
            //{
            //    e.Handled = true; //Girişi engelle.
            //}

            if (!(char.IsDigit(e.KeyChar)||e.KeyChar==(char)Keys.Back)) //Girilen sayı değilse veya backspace değilse demek. Ünlem olmasa tersi.
            {
                e.Handled = true;
            }

        }

        private void txtHarf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)||e.KeyChar==(char)Keys.Back)) //Harf için
            {
                e.Handled = true;
            }

           //e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back); Yukarıdakinin aynısı.
        }

        private void txtBuyukHarf_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsUpper(e.KeyChar)||
                            e.KeyChar==(char)Keys.Back||
                                e.KeyChar==(char)Keys.Space);
        }
    }
}
