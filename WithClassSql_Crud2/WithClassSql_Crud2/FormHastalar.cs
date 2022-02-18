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
    public partial class FormHastalar : Form
    {
        VeriTabani vt = new VeriTabani();
        public FormHastalar()
        {
            InitializeComponent();
        }

        void HastalariTazele()
        {
            string sorguCumlesi = "SELECT   *  FROM tblHastalar";
            dgvHastalar.DataSource = vt.Listele(sorguCumlesi);
        }
        private void FormHastalar_Load(object sender, EventArgs e)
        {
            HastalariTazele();
            dgvHastalar.Columns[0].Visible = false;
        }

        void Aktar()
        {
            rdbErkek.Checked = true;
            txtTC.Text = dgvHastalar.CurrentRow.Cells[1].Value.ToString();
            txtAd.Text = dgvHastalar.CurrentRow.Cells[2].Value.ToString();
            txtSoyad.Text = dgvHastalar.CurrentRow.Cells[3].Value.ToString();
            rdbKadin.Checked = dgvHastalar.CurrentRow.Cells[4].Value.ToString() == "K" ? true : false;
            txtAdres.Text = dgvHastalar.CurrentRow.Cells[5].Value.ToString();
            txtTel.Text = dgvHastalar.CurrentRow.Cells[6].Value.ToString();
            txtMail.Text = dgvHastalar.CurrentRow.Cells[7].Value.ToString();
        }
        void Yeni()
        {
            btnYeni.Text = "KAYDET";
            txtAd.Clear();
            txtSoyad.Clear();
            txtTC.Clear();
            txtTel.Clear();
            txtAdres.Clear();
            txtMail.Clear();
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
            dgvHastalar.Enabled = false;
        }

        void Kaydet()
        {   
            btnYeni.Text = "YENİ";
            string cinsiyet = rdbKadin.Checked == true ? "K" : "E";
            string sorguCumlesi = $@"INSERT INTO tblHastalar 
                                     VALUES(
                                    '{txtTC.Text}',
                                    '{txtAd.Text}',
                                    '{txtSoyad.Text}',
                                    '{cinsiyet}',
                                    '{txtAdres.Text}',
                                    '{txtTel.Text}',
                                    '{txtMail.Text}')";

            vt.Islem(sorguCumlesi);
            HastalariTazele();
            btnGuncelle.Enabled = true;
            btnSil.Enabled = true;
            dgvHastalar.Enabled = true;
        }
        private void btnYeni_Click(object sender, EventArgs e)
        {
            if (btnYeni.Text=="YENİ")
            {
                Yeni();
            }
            else
            {
                Kaydet();
            }
        }

        private void dgvHastalar_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Aktar();
        }

        void Guncelle()
        {
            string id = dgvHastalar.CurrentRow.Cells[0].Value.ToString();
            string cinsiyet = rdbKadin.Checked == true ? "K" : "E";
            string sorguCumlesi = $@"UPDATE tblHastalar SET
                                    TcNo='{txtTC.Text}',
                                    Ad='{txtAd.Text}',
                                    Soyad='{txtSoyad.Text}',
                                    Cinsiyet='{cinsiyet}',
                                    Adres='{txtAdres.Text}',
                                    Telefon='{txtTel.Text}',
                                    Mail='{txtMail.Text}'
                                    WHERE ID={id}";

            vt.Islem(sorguCumlesi);
            HastalariTazele();
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        void Sil()
        {
            string id = dgvHastalar.CurrentRow.Cells[0].Value.ToString();
            string sorguCumlesi = $@"DELETE FROM tblHastalar WHERE ID={id}";
            vt.Islem(sorguCumlesi);
            HastalariTazele();
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

        private void FormHastalar_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormAna anaMenu = new FormAna();
            anaMenu.Show();     
        }
    }
}
