using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WithClassSql_Crud1
{
    public partial class FormDuzeltSil : Form
    {
        VeriTabani vt = new VeriTabani();
        public FormDuzeltSil()
        {
            InitializeComponent();
        }

        void Doldur()
        {
            dvgHastalar.DataSource = vt.HastalariListele();
        }
        private void FormDuzeltSil_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            FormAna anaForm = new FormAna();
            anaForm.Show();
            this.Hide();
        }
       
        void Aktar()
        {
            txtTC.Text = dvgHastalar.CurrentRow.Cells[1].Value.ToString();
            txtAd.Text = dvgHastalar.CurrentRow.Cells[2].Value.ToString();
            txtSoyad.Text = dvgHastalar.CurrentRow.Cells[3].Value.ToString();
            cmbCinsiyet.Text = dvgHastalar.CurrentRow.Cells[4].Value.ToString() == "K" ? "Kadın" : "Erkek";
            txtAdres.Text = dvgHastalar.CurrentRow.Cells[5].Value.ToString();
            txtTelefon.Text= dvgHastalar.CurrentRow.Cells[6].Value.ToString();
            txtMail.Text = dvgHastalar.CurrentRow.Cells[7].Value.ToString();

        }
        private void dvgHastalar_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Aktar();
        }

        private void btnDuzelt_Click(object sender, EventArgs e)
        {
            string id = dvgHastalar.CurrentRow.Cells[0].Value.ToString();
            string cinsiyet = cmbCinsiyet.SelectedIndex == 0 ? "K" : "E";
            vt.Guncelle(id, txtTC.Text,txtAd.Text,txtSoyad.Text,cinsiyet,txtAdres.Text,txtTelefon.Text,txtMail.Text);
            Doldur();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string id = dvgHastalar.CurrentRow.Cells[0].Value.ToString();
            vt.Sil(id);
            Doldur();
        }

        private void FormDuzeltSil_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormAna anaform = new FormAna();
            anaform.Show();
            this.Hide();
        }
    }
}
