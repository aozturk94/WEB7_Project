using PersonelTakipProgramı.DataAccessLayer;
using PersonelTakipProgramı.EntityLayer;
using PersonelTakipProgramı.BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelTakipProgramı
{
    public partial class FormAna : Form
    {
        BL bL = new BL();
        CalisanDAL calisanDAL = new CalisanDAL();
        Calisan calisan = null;
        int secilenID = 0;
        public FormAna()
        {
            InitializeComponent();
        }
        void RefreshAll()
        {
            dgvCalisanlar.DataSource = calisanDAL.GetAll();
        }
        private void FormAna_Load(object sender, EventArgs e)
        {
            RefreshAll();
            ClearTools();
            dgvCalisanlar.Columns[0].Visible = false;
        }

        public void ClearTools()
        {
            foreach (Control control in pnlAraclar.Controls)
            {
                if (control.GetType()==typeof(DateTimePicker)) //O sırada baktıın control'ün tipi datetimericker ise.
                {

                }
                else if (control.GetType()!=typeof(Label)) //"O sırada baktığın control'ün tipi label değilse" demek.
                {
                    control.Text = string.Empty;
                }
                dtpDogumTarihi.Format = DateTimePickerFormat.Custom;
                dtpDogumTarihi.CustomFormat = " ";
                dtpIseBaslamaTarihi.Format = DateTimePickerFormat.Custom;
                dtpIseBaslamaTarihi.CustomFormat = " ";
                dgvCalisanlar.ClearSelection();
                secilenID = 0;
            }
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            RefreshAll();
            ClearTools();
        }

        private void dtpDogumTarihi_ValueChanged(object sender, EventArgs e)
        {
            dtpDogumTarihi.Format = DateTimePickerFormat.Long;
        }

        private void dtpIseBaslamaTarihi_ValueChanged(object sender, EventArgs e)
        {
            dtpIseBaslamaTarihi.Format = DateTimePickerFormat.Long;
        }

        bool CheckBlank()
        {
            bool status = false;
            foreach (Control control in pnlAraclar.Controls)
            {
                if (control.Text==string.Empty||control.Text==" ")
                {
                    status = true;
                    break;
                }
            }
            return status;
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (CheckBlank())
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
            }
            else
            {
                int pNoAdet = calisanDAL.Duplicate($"PersonelNo='{txtPersonelNo.Text}'");
                int tcNoAdet = calisanDAL.Duplicate($"TcNo='{txtTcNo.Text}'");
                if (pNoAdet == 0 && tcNoAdet == 0)
                {
                    calisan = new Calisan
                    {
                        Ad = txtAd.Text,
                        Soyad = txtSoyad.Text,
                        TcNo = txtTcNo.Text,
                        PersonelNo = txtPersonelNo.Text,
                        DogumTarihi = dtpDogumTarihi.Value,
                        IseBaslamaTarihi = dtpIseBaslamaTarihi.Value,
                        Departman = cmbDepartman.SelectedItem.ToString(),
                        Unvan = cmbUnvan.SelectedItem.ToString(),
                        Durumu = cmbDurumu.SelectedItem.ToString()
                    };
                    bool result = calisanDAL.Insert(calisan);
                    if (result)
                    {
                        RefreshAll();
                        MessageBox.Show("Kayıt işlemi başarıyla gerçekleşmiştir.");
                    }
                }
                else if (pNoAdet == 1 && tcNoAdet == 1)
                {
                    MessageBox.Show("Bu personel numarası ve TC kimlik numarası kullanılmaktadır!");

                }
                else if (pNoAdet==1)
                {
                    MessageBox.Show("Bu personel numarası kullanılmaktadır!");
                }
                else
                {
                    MessageBox.Show("Bu TC Kimlik numarası kullanılmaktadır!");
                }
            }
        }
        void Transfer()
        {
            try
            {
                secilenID = Convert.ToInt32(dgvCalisanlar.SelectedRows[0].Cells[0].Value);
                txtAd.Text = dgvCalisanlar.SelectedRows[0].Cells[1].Value.ToString();
                txtSoyad.Text = dgvCalisanlar.SelectedRows[0].Cells[2].Value.ToString();
                txtTcNo.Text = dgvCalisanlar.SelectedRows[0].Cells[3].Value.ToString();
                txtPersonelNo.Text = dgvCalisanlar.SelectedRows[0].Cells[4].Value.ToString();
                dtpDogumTarihi.Value = Convert.ToDateTime(dgvCalisanlar.SelectedRows[0].Cells[5].Value);
                dtpIseBaslamaTarihi.Value = Convert.ToDateTime(dgvCalisanlar.SelectedRows[0].Cells[6].Value);
                cmbDepartman.Text = dgvCalisanlar.SelectedRows[0].Cells[7].Value.ToString();
                cmbUnvan.Text = dgvCalisanlar.SelectedRows[0].Cells[8].Value.ToString();
                cmbDurumu.Text = dgvCalisanlar.SelectedRows[0].Cells[9].Value.ToString();
            }
            catch (Exception)
            {

            }
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (CheckBlank())
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
            }
            else
            {
                calisan = new Calisan
                {
                    Ad = txtAd.Text,
                    Soyad = txtSoyad.Text,
                    TcNo = txtTcNo.Text,
                    PersonelNo = txtPersonelNo.Text,
                    DogumTarihi = dtpDogumTarihi.Value,
                    IseBaslamaTarihi = dtpIseBaslamaTarihi.Value,
                    Departman = cmbDepartman.SelectedItem.ToString(),
                    Unvan = cmbUnvan.SelectedItem.ToString(),
                    Durumu = cmbDurumu.SelectedItem.ToString(),
                    ID = secilenID
                };
                bool result = calisanDAL.Update(calisan);
                if (result)
                {
                    RefreshAll();
                    MessageBox.Show("Güncelleme işlemi başarıyla gerçekleşmiştir.");
                }
            }
        }
        private void dgvCalisanlar_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //dtpDogumTarihi.Format = DateTimePickerFormat.Long;
            //dtpIseBaslamaTarihi.Format = DateTimePickerFormat.Long; //Sorunu çözmek için denedim.
            Transfer();
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (secilenID==0)
            {
                MessageBox.Show("Lütfen silinecek kaydı seçiniz.");
            }
            else
            {
                DialogResult answer = MessageBox.Show("İlgili kaydı silmek istediğinizden emin misiniz?", "DİKKAT!", MessageBoxButtons.YesNo);
                if (answer == DialogResult.Yes)
                {
                    bool result = calisanDAL.Delete(secilenID);
                    if (result)
                    {
                        RefreshAll();
                        ClearTools();
                        MessageBox.Show("Seçili kayıt başarıyla silinmiştir.");
                    }
                }
            }
        }
        private void btnHepsiniSil_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Bu işlem tüm kayıtları KALICI olarak silecektir!\nEmin misiniz?","DİKKAT!",MessageBoxButtons.YesNo);
            if (answer==DialogResult.Yes)
            {
                bool result = calisanDAL.Delete();
                if (result)
                {
                    RefreshAll();
                    ClearTools();
                    MessageBox.Show("Tablodaki tüm veriler silinmiştir.");
                }
            }
        }
        string CreateQuaryString()
        {
            string quary = string.Empty;
            //string quary = "";
            List<string> conditions = new List<string>();
            foreach (Control control in pnlAraclar.Controls)
            {
                if (control.GetType() == typeof(Label)) continue;
                if (String.IsNullOrEmpty(control.Text) || control.Text == " ") continue;
                string columnName = control.Tag.ToString();
                string value;
                if (control.GetType()==typeof(DateTimePicker))
                {
                    value = Convert.ToDateTime(control.Text).ToString("yyyy-MM-dd");
                    conditions.Add($"{columnName} = '{value}'");
                }
                else
                {
                    value = control.Text;
                    if (rdbTam.Checked)
                    {
                        conditions.Add($"{columnName} = '{value}'");
                    }
                    else if (rdbIceren.Checked)
                    {
                        conditions.Add($"{columnName} LIKE '%{value}%'");
                    }
                    else if(rdbBaslangic.Checked)
                    {
                        conditions.Add($"{columnName} LIKE '{value}%'");
                    }
                }
            }
            quary = "WHERE "+string.Join(" AND ", conditions);//Birleştirmek için bu şekilde ilerleyebiliriz.
            return quary;
        }
        private void btnBul_Click(object sender, EventArgs e)
        {
            dgvCalisanlar.DataSource = calisanDAL.GetAll(CreateQuaryString());
        }
        private void btnGetir_Click(object sender, EventArgs e)
        {
            Calisan calisan = new Calisan();
            calisan = calisanDAL.GetSpecific(CreateQuaryString());
            if (calisan!=null)
            {
                txtAd.Text = calisan.Ad;
                txtSoyad.Text = calisan.Soyad;
                txtTcNo.Text = calisan.TcNo;
                txtPersonelNo.Text = calisan.PersonelNo;
                dtpDogumTarihi.Format = DateTimePickerFormat.Long;
                dtpDogumTarihi.Value = calisan.DogumTarihi;
                dtpIseBaslamaTarihi.Format = DateTimePickerFormat.Long;
                dtpIseBaslamaTarihi.Value = calisan.IseBaslamaTarihi;
                cmbDepartman.Text = calisan.Departman;
                cmbUnvan.Text = calisan.Unvan;
                cmbDurumu.Text = calisan.Durumu;  
            }
        }
    }
}

