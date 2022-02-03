using System;

namespace Proje_05_Convert_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            /*   string ad;
               Console.Write("Adınızı Giriniz: ");
               ad = Console.ReadLine();
               int yas;
               Console.Write("Yaşınızı Giriniz: ");
               //yas = Convert.ToInt32(Console.ReadLine()); Bu metodla türler arası geçiş yapılabilir.
               yas = int.Parse(Console.ReadLine()); //Sadece string => sayısal türler arası geçiş yapmak için kullanılır.
               Console.WriteLine($"Merhaba {ad}, sen {yas} yaşındasın."); */

            /*int sNot = Convert.ToInt32(Console.ReadLine());
            double gNot = sNot * 17/100;
            Console.WriteLine(gNot);*/

            /*byte sayi = 96;
            int sayi2 = sayi;*/

            ushort sayi = 400;
            byte sayi2 = (byte)sayi; // (byte)sayi => sayiyi byte'a (vb.) böyle de dönüştürebilirsin.
            //Console.WriteLine(sayi.GetType()); => Tipini öğrenmek için
            Console.WriteLine(sayi2);

            Console.ReadLine();
        }
    }
}
