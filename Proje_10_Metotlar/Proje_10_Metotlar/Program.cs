using System;

namespace Proje_10_Metotlar
{
    class Program
    {
        static void Main(string[] arg)
        {
            //Parametre almayan ve geri değer döndürmeyen metotlar!
            void Toplama()
            {
                int s1 = 10;
                int s2 = 20;
                Console.WriteLine(s1+s2);
            }
            
            void GirisYap()
            {
                Console.Clear();
                Console.WriteLine("Lütfen Kullanıcı Adını Giriniz: ");
                string ad = Console.ReadLine();
            }

            //Parametre alan ve geri değer döndürmeyen metot!
            void Merhaba(string ad, int yil)
            {
                Console.WriteLine($"Merhaba {ad}, hoşgeldin! Bu, {yil}. yılın.");
            }

            /*int a = 5;*/

            //Geri değer döndüren ama parametre almayan metot!
          /*  int KareBul()
            {
                return a * a;
            }*/

            int Kare2(int kenarUzunlugu)
            {
                return kenarUzunlugu * kenarUzunlugu;
            }

            int karesinibul = Kare2(7);
            Console.WriteLine(karesinibul);

            /*int karesi = KareBul();
            Console.WriteLine(karesi);*/

            /*Merhaba("Ahmet",8);
            Merhaba("Ali",12);
            Merhaba("Ayşe",4);*/

            /* Toplama();
             Console.WriteLine("Hello World!");
             Console.ReadLine();
             GirisYap();
             Console.WriteLine("Hello World!");
             Toplama();
             Toplama();
             Console.ReadLine();
             GirisYap();*/

            Console.ReadLine();
        }
    }
}
