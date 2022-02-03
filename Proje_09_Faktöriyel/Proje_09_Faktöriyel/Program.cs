using System;

namespace Proje_09_Faktöriyel
{
    class Program
    {
        static void Main(string[] args)
        {
            int sonuc = 1;
            Console.WriteLine("Sayıyı Giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= sayi; i++)
            {
                sonuc = sonuc * i;
            }
            Console.WriteLine($"{sayi}!= {sonuc}");
            Console.ReadLine();
        }
    }
}
