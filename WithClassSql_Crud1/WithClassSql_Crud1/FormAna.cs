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
    public partial class FormAna : Form
    {
        VeriTabani vt = new VeriTabani();
        public FormAna()
        {
            InitializeComponent();
        }

        private void FormAna_Load(object sender, EventArgs e)
        {
            dgvHastalar.DataSource = vt.HastalariListele();
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {   
            
            FormYeni yeniKayit = new FormYeni();
            yeniKayit.Show();
            this.Hide();
        }

        private void FormAna_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnDsil_Click(object sender, EventArgs e)
        {
            FormDuzeltSil dSil = new FormDuzeltSil();
            dSil.Show();
            this.Hide();
            
        }
    }
}
