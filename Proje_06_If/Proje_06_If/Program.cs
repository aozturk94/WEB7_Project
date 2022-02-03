using System;

namespace Proje_06_If
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad = "Ahmet";
            Console.WriteLine("Adınızı Giriniz: ");
            string gAd = Console.ReadLine();
            if (gAd==ad)
            {
                //True ise yapılacaklar
                Console.WriteLine($"Hoşgeldin {ad}");
            }

            else if (gAd=="Ali")
            {
                Console.WriteLine($"{gAd} bey lütfen parolanızı güncellemek için IT ile görüşünüz");
            }

            else
            {
                //False ise yapılacaklar

                Console.WriteLine($"{gAd} adlı kullanıcı bululamadı!");

            }

            Console.ReadLine();
        }
    }
}
