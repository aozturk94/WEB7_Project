using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneProjesi
{
    public partial class FormKutuphane : Form
    {
        VeriTabani vt = new VeriTabani();
        public FormKutuphane()
        {
            InitializeComponent();
        }

        private void FormKutuphane_Load(object sender, EventArgs e)
        {   //Ödünç işlemleri gridimizi dolduruyor.
            vt.TableName = "tblOdunc";
            vt.Islem();
            dgvOdunc.DataSource = vt.dt;

            //Üye listemizi dolduruyor.
            vt.TableName = "tblUyeler";
            vt.Islem();
            dgvOduncUye.DataSource = vt.dt;
            for (int i = 0; i < dgvOduncUye.ColumnCount; i++)
            {
                dgvOduncUye.Columns[i].Visible = false;
            }
            //dgvOduncUye.Columns[0].Visible = true;
            dgvOduncUye.Columns[1].Visible = true;
            dgvOduncUye.Columns[1].HeaderText = "Üye Adı";

            //Kitaplar listemizi dolduruyor.
            vt.TableName = "tblKitaplar";
            vt.Islem();
            dgvOduncKitap.DataSource = vt.dt;
            for (int i = 0; i < dgvOduncKitap.ColumnCount; i++)
            {
                dgvOduncKitap.Columns[i].Visible = false;
            }
            //dgvOduncKitap.Columns[0].Visible = true;
            dgvOduncKitap.Columns[1].Visible = true;
            dgvOduncKitap.Columns[1].HeaderText = "Kitap Adı";
            pnlOduncTeslimTarihi.Visible = false;
            dtpOduncTeslimETarihi.Text = dtpOduncVerilisTarihi.Value.AddDays(5).ToString();

        }

        private void tapOdunc_Click(object sender, EventArgs e)
        {

        }
        private void dtpOduncVerilisTarihi_ValueChanged(object sender, EventArgs e)
        {
            dtpOduncTeslimETarihi.Text = dtpOduncVerilisTarihi.Value.AddDays(5).ToString();
        }
        private void btnOduncVer_Click(object sender, EventArgs e)
        {
            Odunc yeniOdunc = new Odunc();
            yeniOdunc.UyeID = Convert.ToInt32(dgvOduncUye.SelectedRows[0].Cells[0].Value.ToString());
            yeniOdunc.KitapISBN = dgvOduncKitap.SelectedRows[0].Cells[0].Value.ToString();
            yeniOdunc.VerilisTarihi = dtpOduncVerilisTarihi.Value;
            yeniOdunc.Durum = false; //Yeni bu kayıt silinmiş değil.
            vt.TableName = "tblOdunc";
            vt.Islem(yeniOdunc);
            //Ödünç işlemleri gridimizi dolduruyor.
            
            vt.Islem();
            dgvOdunc.DataSource = vt.dt;
        }

        private void btnOduncİptal_Click(object sender, EventArgs e)
        {
            Odunc IptalOdunc = new Odunc();
            string silinecekID = dgvOdunc.SelectedRows[0].Cells[0].Value.ToString();
                        vt.TableName = "tblOdunc";
            vt.Islem(silinecekID);
            vt.Islem();
            dgvOdunc.DataSource = vt.dt;
        }
    }
}
