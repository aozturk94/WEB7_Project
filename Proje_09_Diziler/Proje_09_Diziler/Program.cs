using System;

namespace Proje_09_Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //klavyeden girilecek 3 tane saynn içinden en byük sayıyı ekrana yaznız.
            /*int sayi=0;
            int enBuyuk = 0;
            for (int i = 1; i <=3; i++)
            {
                Console.WriteLine($"{i}. sayıyı gir: ");
                sayi = int.Parse(Console.ReadLine());

                if (sayi>enBuyuk)
                {
                    enBuyuk = sayi;
                }
            }
            Console.WriteLine($"En büyük sayı: {enBuyuk}");
            Console.ReadLine();*/


            /*int[] sayilar = { 4, 6, 9 };

            Console.WriteLine(sayilar[1]);*/

            /*Random rnd = new Random();*/
            /*int rastgeleSayi = rnd.Next(1,100);
            Console.WriteLine(rastgeleSayi);*/

            //Diziye 10 adet rastgele değer atyoruz.


            /*Rastgele 5 değer oluşturalım (1 ile 100 arasında)
             * Daha sonra sorasını ters çevirelim.*/

            /*int[] dizi = new int[5];

            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rnd.Next(1, 100);
            }

            for (int i = 0; i < dizi.Length; i++)
            {
                Console.WriteLine(dizi[i]);


            }

            Console.WriteLine();

            for (int i = 4; i >=0; i--)
            {
                Console.WriteLine(dizi[i]);
            }*/



            /*FOR EACH*/

            /*string[] kisiler = { "Elif", "Ayşen", "Umay", "Begüm", "Eda" };

            foreach (var kisi in kisiler)
            {
                Console.WriteLine(kisi);
            }

            Console.ReadLine();*/


            int tahmin=0;
            string a = "";

            do
            {
                Random rnd = new Random();
                int sayi = rnd.Next(1, 100);
                Console.WriteLine($"Sayımız: {sayi}");
                for (int i = 1; i <= 5; i++)
                {
                    Console.Write($"{i}. Tahmininizi Yazınız: ");
                    tahmin = int.Parse(Console.ReadLine());

                    if (tahmin < sayi && i != 5)
                    {
                        Console.WriteLine("Sayıyı Arttırınız!");
                    }
                    else if (tahmin > sayi && i != 5)
                    {
                        Console.WriteLine("Sayıyı Küçültünüz!");
                    }

                    else if (tahmin == sayi)
                    {


                        Console.WriteLine("Doğru Bildiniz!");
                        Console.WriteLine($"Puanınız: {50-i*10}");
                        break;
                    }

                    if (i == 5 && sayi != tahmin)
                    {
                        Console.WriteLine("Hakkınız Bitti!");
                    }
                    Console.WriteLine($"Kalan puanınız: {50 - i * 10}");
                }

                Console.WriteLine("Oyuna devam etmek ister misiniz [Y]/[N]?");
                a = Console.ReadLine();
                Console.Clear();

            } while (a != "N");

            Console.ReadLine();





        }
    }
}
