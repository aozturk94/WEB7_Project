using System;

namespace Proje_11_Metotlar_Örnek2
{
    class Program
    {
        /*static int Topla(int number1, int number2) //Static Mainden Çağırmak için Static olması lazım.
        {
            return number1 + number2;
        }

        static int Topla(int number1, int number2, int number3) //Birebir aynı olmamak ve ismi ayn olmak şartı ile ifadeler aynı olabilir. "Overload". Uyumlu olan bulup kendi kullanır.
        {
            return number1+number2 + number3;
        }*/


        static int Faktöriyel(int number)
        {
            int a = 1;

            for (int i = 1; i <= number; i++)
            {
                a = a * i;
            }
            return a;
        }

        static int EnBuyuk(int[] sayilar)
        {
            int enb = 0;
            foreach (var sayi in sayilar)
            {
                if (sayi>=enb)
                {
                    enb = sayi;
                }
            }
            return enb;
        }

                static int BuyukKucuk(int[] sayilar, bool tur)
        {
            int sonuc = sayilar[0];
            foreach (var sayi in sayilar)
            {
                if (tur)
                {
                    if (sayi >= sonuc)
                    {
                        sonuc = sayi;
                    }
                }
                else
                {
                    if (sayi<=sonuc)
                    {
                        sonuc = sayi;
                    }
                }
            }
            return sonuc;
        }
        static void Main(string[] args)
        {
            int[] sayilar = { 50, 450, 87, 96, 65, 960, 1487 };
            int Buyuk = EnBuyuk(sayilar);
            Console.WriteLine(Buyuk);
            Console.ReadLine();

            Console.Clear();
            Buyuk = BuyukKucuk(sayilar, true);
            Console.WriteLine(Buyuk);
            Buyuk = BuyukKucuk(sayilar, false);
            Console.WriteLine(Buyuk);
            Console.ReadLine();

            /*Console.Write("Sayıyı Giriniz: ");
            int sayi=int.Parse(Console.ReadLine());
            Console.WriteLine($"{sayi}!= {Faktöriyel(sayi)}");
            Console.ReadLine();*/

            /*Console.WriteLine(Topla(5, 6));
            Console.ReadLine();
            Console.WriteLine(Topla(6, 7, 4));
            Console.ReadLine();*/
        }
    }
}
