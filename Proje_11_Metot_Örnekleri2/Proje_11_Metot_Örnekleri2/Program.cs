using System;

namespace Proje_11_Metot_Örnekleri2
{
    class Program
    {
        double pii = 3;
        double alan = 0;
        static double Alan(double r , double sayi)
        {
            if (sayi==3.14)
            {
                return sayi;
            }
            return r;
        }
       static int enBuyukBul(int[] sayilar)
        {
            int enb = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i]>enb)
                {
                    enb = sayilar[i];
                }
            }
            return enb;
        }
        static void Main(string[] args)
        {
            int[] sayilar = { 15,5678, 76,196,647,1987 };
            int buyuk = enBuyukBul(sayilar);
            Console.WriteLine( buyuk); 
            Console.ReadLine();
        }
    }
}
