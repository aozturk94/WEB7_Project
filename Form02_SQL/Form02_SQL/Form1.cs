using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form02_SQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection baglanti = new SqlConnection(); //Veri tabanına bağlanabilmem için ilk adım.
                baglanti.ConnectionString = @"Server=DESKTOP-MTU4EKB\SQLEXPRESS; Database=Sirket50; User=sa; Pwd=123;"; //Bağlantıyı bana anlatacak metin. Metinsel bir değer. Server adı, Database, User, ID değerlerini almalıyız. Kullancı adı ve şifre belirtir isek authentication ile bağlantığımızı anlar. 
                //Üstteki satır SQL Server Authentication için kullanılır.
                //baglanti.ConnectionString = @"Server=DESKTOP-MTU4EKB\SQLEXPRESS; Database=Sirket50; Trusted_Connection=True;"; 
                //Üstteki satır Windows Authentication için kullanılır.

                baglanti.Open();

                //işlemler
                //işlemleri bu araya yazmalıyız.

                baglanti.Close();
                MessageBox.Show("Bağlantı Başarılı");
            }
            catch (Exception ex) //ex diye değişken tanımlayıp hatanın orda tutulmasını sağladık.
            {
                //MessageBox.Show("Olmadı yar, su testisine dolmadı yar.");
                //throw;
                MessageBox.Show(ex.Message); //Hatanın nedenini öğrenmek için bunu yapıyoruz.
            }
            
        }
    }
}
