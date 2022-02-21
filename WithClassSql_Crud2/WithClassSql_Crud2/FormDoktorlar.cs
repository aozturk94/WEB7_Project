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
    public partial class FormDoktorlar : Form
    {
        VeriTabani vt = new VeriTabani();
        public FormDoktorlar()
        {
            InitializeComponent();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {

        }
        
        void DoktorlariListele()
        {
            string sorguCumlesi = $"SELECT*FROM tblDoktorlar";
            dgvDoktorlar.DataSource = vt.Listele(sorguCumlesi);
        }
        private void FormDoktorlar_Load(object sender, EventArgs e)
        {
            DoktorlariListele();
            dgvDoktorlar.Columns[0].Visible = false;
            cmbBolum.DataSource = vt.Listele("SELECT*FROM tblBolumler"); //comboBox da datasource'a sahip. Çağırabiliriz.
            cmbBolum.DisplayMember = "BolumAd";
            cmbBolum.ValueMember = "ID"; //Bu kısmını kütüphane otomasyonuna ekle.
        }

        private void FormDoktorlar_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormAna anaForm = new FormAna();
            anaForm.Show();
            this.Hide();
        }
    }
}
