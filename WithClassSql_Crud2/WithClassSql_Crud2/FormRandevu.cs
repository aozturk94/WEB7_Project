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
    public partial class FormRandevu : Form
    {
        VeriTabani vt = new VeriTabani();
        string sorguCumlesi;
        public FormRandevu()
        {
            InitializeComponent();
        }

        void BolumDoldur()
        {
            sorguCumlesi = "SELECT*FROM tblBolumler";
            cmbBolumler.DataSource = vt.Listele(sorguCumlesi);
            cmbBolumler.DisplayMember = "BolumAd";
            cmbBolumler.ValueMember = "ID";
        }

        void DoktorDoldur()
        {
            sorguCumlesi = $"SELECT*FROM tblDoktorlar WHERE BolumID='{cmbBolumler.SelectedValue.ToString()}'"; //Seçilen bölümlere ait doktorlar gelsin diye yapıldı. İncele.
            lstDoktorlar.DataSource = vt.Listele(sorguCumlesi);
            lstDoktorlar.DisplayMember = "AdSoyad";
            lstDoktorlar.ValueMember = "ID";
        }

        void HastalariDoldur() //Burayı da incele
        {
            sorguCumlesi = $"SELECT ID,Ad,Soyad,Cinsiyet FROM tblHastalar";
            dgvHastalar.DataSource = vt.Listele(sorguCumlesi);
        }
        private void FormRandevu_Load(object sender, EventArgs e)
        {
            BolumDoldur(); //Bölüm dolu olmadan doktoru doldurursa hata verir. Bölüm olmadan doktora erişemez. Aşağıdaki gib try/catch kullanılabilir.
            DoktorDoldur();
            HastalariDoldur();
            dgvHastalar.Columns[0].Visible = false;
        }

        private void cmbBolumler_SelectedIndexChanged(object sender, EventArgs e)
        {
            try //Hata yoksa alttakini çalıştır varsa çalıştırma. İlk başta boş olduğu için atayamıyor. Bu kısımı eklemeden if ile uzun olur.
            {
                DoktorDoldur(); //Her bölüm seçildiğinde doktorları tazele.
            }
            catch (Exception)
            {

                //throw;
            }
        }

        private void FormRandevu_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormAna anaForm = new FormAna();
            anaForm.Show();
            this.Hide();
        }

        void RandevuOlustur()
        {
            string BolumID = cmbBolumler.SelectedValue.ToString();
            string DoktorlarID = lstDoktorlar.SelectedValue.ToString();
            string HastaID = dgvHastalar.CurrentRow.Cells[0].Value.ToString();
            string Tarih = dtpTarih.Value.ToString("yyyy-MM-dd");
            sorguCumlesi=$@"INSERT INTO tblRandevu VALUES
                ('{BolumID}','{DoktorlarID}','{HastaID}','{Tarih}')";
            vt.Islem(sorguCumlesi);
        }
        private void btnRandevu_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Bu bilgilerle randevu oluşturulacaktır. \nEmin misiniz?", "DİKKAT!", MessageBoxButtons.YesNo);
            if (cevap == DialogResult.Yes)
            {
                RandevuOlustur();
                MessageBox.Show("RANDEVU OLUŞTURULDU.");
            } //Bu kısmı yeni form oluşturarak yap! MustafaBukulmez'den bak
        }
    }
}
