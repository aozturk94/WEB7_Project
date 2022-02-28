using PersonelTakipProgramı.DataAccessLayer;
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
        public FormAna()
        {
            InitializeComponent();
        }

        private void FormAna_Load(object sender, EventArgs e)
        {
            dgvCalisanlar.DataSource = calisanDAL.GetAll();
        }

        public void ClearTools()
        {
            foreach (Control control in pnlAraclar.Controls)
            {
                if (control.GetType()!=typeof(Label)) //"O sırada baktığın control'ün tipi label değilse" demek.
                {
                    control.Text = string.Empty;
                }
            }
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            ClearTools();
        } 
    }
}

