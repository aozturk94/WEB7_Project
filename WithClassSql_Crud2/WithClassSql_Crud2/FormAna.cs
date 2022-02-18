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
    public partial class FormAna : Form
    {
        public FormAna()
        {
            InitializeComponent();
        }

        private void btnHastalar_Click(object sender, EventArgs e)
        {
            FormHastalar hastaMenu = new FormHastalar();
            hastaMenu.Show();
            this.Hide();
        }

        private void btnBolumler_Click(object sender, EventArgs e)
        {
            FormBolumler bolumMenu = new FormBolumler();
            bolumMenu.Show();
            this.Hide();
        }

        private void FormAna_Load(object sender, EventArgs e)
        {

        }

        private void FormAna_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnDoktorlar_Click(object sender, EventArgs e)
        {

        }
    }
}
