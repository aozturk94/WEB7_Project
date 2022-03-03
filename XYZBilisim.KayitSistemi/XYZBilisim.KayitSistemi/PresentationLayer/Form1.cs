using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XYZBilisim.KayitSistemi.DataAccesLayer.DAL;
using XYZBilisim.KayitSistemi.EntityLayer;

namespace XYZBilisim.KayitSistemi
{
    public partial class Form1 : Form
    {
        KayitlarDAL kayitlarDAL = new KayitlarDAL();
        Kayit kayit = new Kayit();
        int secilenID = 0;
        public Form1()
        {
            InitializeComponent();
        }
        void RefreshAll()
        {
            dgvKayitSistemi.DataSource = kayitlarDAL.GetAll();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshAll();
            ClearTools();
        }

        bool CheckBlank()
        {
            bool blank = false;

            foreach (Control control in pnlControl.Controls)
            {
                if (control.Text == string.Empty)
                {
                    blank = true;
                    break;
                }
            }
            return blank;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (CheckBlank())
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz!");
            }
            else
            {
                kayit = new Kayit
                {
                    AdSoyad = txtAdSoyad.Text,
                    EgiticiAdSoyad = txtEgiticiAdSoyad.Text,
                    Yil = Convert.ToInt32(txtYil.Text)
                };

                bool result = kayitlarDAL.Insert(kayit);
                if (result)
                {
                    RefreshAll();
                    MessageBox.Show("Kayıt işlemi başarıyla gerçekleşmiştir.");
                    ClearTools();
                }
                else
                {
                    MessageBox.Show("Kayıt işlem Başarısız!");
                    ClearTools();
                }
            }
        }
        void Transfer()
        {
            try
            {
                secilenID = Convert.ToInt32(dgvKayitSistemi.SelectedRows[0].Cells[0].Value);
                txtAdSoyad.Text = dgvKayitSistemi.SelectedRows[0].Cells[1].Value.ToString();
                txtEgiticiAdSoyad.Text = dgvKayitSistemi.SelectedRows[0].Cells[2].Value.ToString();
                txtYil.Text = dgvKayitSistemi.SelectedRows[0].Cells[3].Value.ToString();
            }
            catch (Exception)
            {
            }
        }
        public void ClearTools()
        {
            foreach (Control control in pnlControl.Controls)
            {
                if (control.GetType() != typeof(Label)) //"O sırada baktığın control'ün tipi label değilse" demek.
                {
                    control.Text = string.Empty;
                }
                dgvKayitSistemi.ClearSelection();
                secilenID = 0;
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (secilenID == 0)
            {
                MessageBox.Show("Lütfen silinecek kaydı seçiniz.");
            }
            else
            {
                DialogResult answer = MessageBox.Show("İlgili kaydı silmek istediğinizden emin misiniz?", "DİKKAT!", MessageBoxButtons.YesNo);
                if (answer == DialogResult.Yes)
                {
                    bool result = kayitlarDAL.Delete(secilenID);
                    if (result)
                    {
                        RefreshAll();
                        ClearTools();
                        MessageBox.Show("Seçili kayıt başarıyla silinmiştir.");
                    }
                }
            }
        }

        private void dgvKayitSistemi_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Transfer();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (CheckBlank())
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
            }
            else
            {
                kayit = new Kayit()
                {
                    AdSoyad = txtAdSoyad.Text,
                    EgiticiAdSoyad = txtEgiticiAdSoyad.Text,
                    Yil = Convert.ToInt32(txtYil.Text)
                };
                bool result = kayitlarDAL.Update(kayit);
                if (result)
                {
                    RefreshAll();
                    ClearTools();
                    MessageBox.Show("Güncelleme işlemi başarıyla gerçekleşmiştir.");
                }
            }
        }
        string CreateQuery()
        {
            string query = string.Empty;
            List<string> conditions = new List<string>();
            foreach (Control  control in pnlControl.Controls)
            {
                if (control.GetType() == typeof(Label)) continue;
                if (String.IsNullOrEmpty(control.Text) || control.Text == " ") continue; 
                string columnName = control.Tag.ToString();
                string value = control.Text;

                if (rdbTam.Checked)
                {
                    conditions.Add($"{columnName} = '{value}'");
                }
                else if (rdbIceren.Checked)
                {
                    conditions.Add($"{columnName} LIKE '%{value}%'");
                }
                else if (rdbBaslayan.Checked)
                {
                    conditions.Add($"{columnName} LIKE '{value}%'");
                }
            }
            query = "WHERE " + string.Join(" AND ", conditions);//Birleştirmek için bu şekilde ilerleyebiliriz.
            return query;
        }
        private void btnBul_Click(object sender, EventArgs e)
        {
            dgvKayitSistemi.DataSource = kayitlarDAL.GetAll(CreateQuery());
        }

        private void btnHepsiniSil_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Bu işlem tüm kayıtları KALICI olarak silecektir!\nEmin misiniz?", "DİKKAT!", MessageBoxButtons.YesNo);
            if (answer == DialogResult.Yes)
            {
                bool result = kayitlarDAL.Delete();
                if (result)
                {
                    RefreshAll();
                    ClearTools();
                    MessageBox.Show("Tablodaki tüm veriler silinmiştir.");
                }
            }
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            Kayit kayit = new Kayit();
            kayit = kayitlarDAL.GetSpecific(CreateQuery());
            if (kayit != null)
            {
                txtAdSoyad.Text = kayit.AdSoyad;
                txtEgiticiAdSoyad.Text = kayit.EgiticiAdSoyad;
                txtYil.Text = kayit.Yil.ToString();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            ClearTools();
        }
    }
}
