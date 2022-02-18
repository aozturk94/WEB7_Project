using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WithClassSql_Crud2
{
    public partial class FormBolumler : Form
    {
        VeriTabani vt = new VeriTabani();
        public FormBolumler()
        {
            InitializeComponent();
        }

        private void FormBolumler_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormAna anaMenu = new FormAna();
            anaMenu.Show();
            this.Hide();
        }

        void BolumleriTazele()
        {
            string sorguCumlesi = "SELECT * FROM tblBolumler";
            dgvBolumler.DataSource = vt.Listele(sorguCumlesi);
        }

        void Yeni()
        {
            btnYeni.Text = "KAYDET";
            txtBolumAd.Clear();
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
            dgvBolumler.Enabled = false;
        }

        void Kaydet()
        {
            btnYeni.Text = "YENİ";
            string sorguCumlesi = $@"INSERT INTO tblBolumler 
                                     VALUES('{txtBolumAd.Text}')";

            vt.Islem(sorguCumlesi);
            BolumleriTazele();
            btnGuncelle.Enabled = true;
            btnSil.Enabled = true;
            dgvBolumler.Enabled = true;
        }
        private void FormBolumler_Load(object sender, EventArgs e)
        {
            BolumleriTazele();
            dgvBolumler.Columns[0].Visible = false;
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {

            if (btnYeni.Text == "YENİ")
            {
                Yeni();
                txtBolumAd.Focus();
            }
            else
            {
                Kaydet();
            }
        }

        void Guncelle()
        {
            string id = dgvBolumler.CurrentRow.Cells[0].Value.ToString();
            string sorguCumlesi = $"UPDATE tblBolumler SET BolumAd='{txtBolumAd.Text}' WHERE ID='{id}'";
            vt.Islem(sorguCumlesi);
            BolumleriTazele();
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        void Sil()
        {
            string id = dgvBolumler.CurrentRow.Cells[0].Value.ToString();
            string sorguCumlesi = $@"DELETE FROM tblBolumler WHERE ID={id}";
            vt.Islem(sorguCumlesi);
            BolumleriTazele();
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Silmek istediğinizden emin misiniz?", "DİKKAT!", MessageBoxButtons.YesNo);
            if (cevap == DialogResult.Yes)
            {
                Sil();
                MessageBox.Show("Kayıt Silindi!");
            }
            else
            {
                MessageBox.Show("Silme işleminden vazgeçildi.");
            }
        }
    }
}
