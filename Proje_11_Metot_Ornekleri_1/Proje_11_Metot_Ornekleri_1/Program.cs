using System;

namespace Proje_11_Metot_Ornekleri_1
{
    class Program
    {
        static void Main(string[] args)
        { string tercih;
            do
            {

                int rastgeleSayi()
                {
                    Random rnd = new Random();
                    int sayi = rnd.Next(1, 100);
                    Console.WriteLine(sayi);
                    return sayi;
                }
                int sayiUret()
                {
                    Console.Write("Bir sayı giriniz:   ");
                    int tahmin = int.Parse(Console.ReadLine());
                    return tahmin;
                }
                int sayac = 5;
                int random = rastgeleSayi();
                do
                {

                    int sayi1 = sayiUret();// Bu sekilde yapıldığnda metod içindekini ekrana yansıtr.

                    if (random == sayi1)
                    {
                        Console.WriteLine("TEBRİKLER");
                        Console.ReadLine();
                        Console.Clear();
                        break; //Environment.Exit();// program komple kapatıyor.
                    }
                    else
                    {
                        Console.WriteLine("Tekrar Deneyin");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    sayac--;
                } while (sayac > 0);
                Console.WriteLine("Oyun Bitti");
                Console.WriteLine($"Puanınız:{ sayac * 10}");
                Console.ReadLine();
                Console.WriteLine("Yeniden Oynamak İstermsinizE/H");
                tercih = Console.ReadLine();
            } while (tercih != "H");
        }
    }
}
