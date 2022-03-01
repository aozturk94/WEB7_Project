﻿using PersonelTakipProgramı.DataAccessLayer;
using PersonelTakipProgramı.EntityLayer;
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
        }

        public void ClearTools()
        {
            foreach (Control control in pnlAraclar.Controls)
            {
                /*if (control.GetType()==typeof(DateTimePicker)) //O sırada baktıın control'ün tipi datetimericker ise.
                {
                    dtpDogumTarihi.CustomFormat = "";
                    dtpIseBaslamaTarihi.CustomFormat = "";
                }//Eksiklik var*/

                if (control.GetType()!=typeof(Label)) //"O sırada baktığın control'ün tipi label değilse" demek.
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
    }
}

