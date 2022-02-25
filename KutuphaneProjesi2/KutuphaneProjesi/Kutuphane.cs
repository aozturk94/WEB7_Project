using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneProjesi
{
    class Kutuphane
    {

    }
    public class Tur
    {
        private int id;
        public int ID
        {
            get { return id; } //ID'ye dışarıdan müdahale olmasın, READ ONLY olsun diye set durumunu kaldırdık. O yüzden FullProp kullandık.   
        }
        public string Ad { get; set; }
    }
    public class YayinEvi
    {
        private int id; /*private readonly int id; ?*/
        public int ID
        {
            get { return id; } //ID'ye dışarıdan müdahale olmasın, READ ONLY olsun diye set durumunu kaldırdık. O yüzden FullProp kullandık.   
        }
        public string Ad { get; set; }
        public string Adres { get; set; }
        public string Tel { get; set; }
    }
    public class Kisi
    {
        private int id;
        public int ID
        {
            get { return id; } //ID'ye dışarıdan müdahale olmasın, READ ONLY olsun diye set durumunu kaldırdık. O yüzden FullProp kullandık.   
        }
        public string AdSoyad { get; set; }
        public string Cinsiyet { get; set; }
        public DateTime DogumTarihi { get; set; }
    }
    public class Yazar : Kisi
    {
        public int TurID { get; set; }
        public string Uyruk { get; set; }
        public DateTime OlumTarihi { get; set; }
    }
    public class Uye : Kisi
    {
        public Uye() //Default olarak false ama görmek istersek böyle yazabiliriz.
        {
            CezaDurumu = false;
        }
        public enum UTip
        {
            Standart,
            Elit
        }
        public DateTime UyelikTarihi { get; set; }
        public UTip UyeTipi { get; set; }
        public string TcNO { get; set; }
        public string Tel { get; set; }
        public string Mail { get; set; }
        public string Meslek { get; set; } //Enum yapılabilir. Ama en doğrusu tablo yapıp "ID" değerini tutmak.
        public enum ETip
        {
            Ilkokul,
            Ortaokul,
            Lise,
            Onlisans,
            Lisans,
            YuksekLisans,
            Doktora,
            Ogrenci
        }
        public ETip EtigimDurumu { get; set; }
        public bool CezaDurumu { get; set; } //False ise cezalı değil (Default olarak 'false')
    }
    public class Kitap
    {
        public string ISBN { get; set; }
        public string Ad { get; set; }
        public int SayfaSayisi { get; set; }
        public int Stok { get; set; }
        public int TurID { get; set; }
        public int YazarID { get; set; }
        //Birden fazla yazar için burada revize yapılacak.
        public int YayinEviID { get; set; }
        public DateTime BasimTarihi { get; set; }
        public DateTime KayitTarihi { get; set; }
    }
    public class Odunc
    {
        private int id;
        public int ID
        {
            get { return id; } //ID'ye dışarıdan müdahale olmasın, READ ONLY olsun diye set durumunu kaldırdık. O yüzden FullProp kullandık.   
        }
        public string Ad { get; set; }
        public int UyeID { get; set; }
        public string KitapISBN { get; set; }
        public DateTime VerilisTarihi { get; set; }
        public DateTime TeslimTarihi { get; set; }
        public bool Durum { get; set; } //Silinmişse true yapıcak.
    }

}
