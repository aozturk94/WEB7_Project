using AlSatProjesi_01.BusinessLayer;
using AlSatProjesi_01.EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlSatProjesi_01
{
    public partial class Form1 : Form
    {
        BL bl = new BL();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbUrunAdi.DataSource = bl.GetProducts;
            cmbUrunAdi.DisplayMember = "ProductName";
            cmbUrunAdi.ValueMember = "ID";
        }

        private void btnSat_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders();

            orders.ProductID = Convert.ToInt32(cmbUrunAdi.SelectedValue);
            orders.SoldQuantity = Convert.ToInt32(nudMiktar.Value);
            orders.OrderDate = Convert.ToDateTime(dtpSatisTarihi.Value.ToString("yyyy-MM-dd"));
            bool result = bl.BLSave(orders);
            if (result)
            {
                MessageBox.Show("Satış Başarıyla Gerçekleşti.");
                bl.StockCalculate(Convert.ToInt32(nudMiktar.Value), orders.ProductID);
            }
        }
    }
}
