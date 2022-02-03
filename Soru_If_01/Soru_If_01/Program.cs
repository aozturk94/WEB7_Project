using System;

namespace Soru_If_01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Bir öğrencinin not ortalaması vize notunun yüzde 40'ı final notunun yüzde 60'nın toplanması ile elde edilmektedir. Geçme notu ise 60'dır.
             Buna göre;
             * Vize ve Final notu girilen öğrencinin başar durumunu ve not ortalamasınıı gösteren programı yazınız. */

            int vize, final, ortalama, gNot;
            gNot = 60;

            Console.WriteLine("Öğrencinin vize notunu giriniz: ");
            vize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Öğrencinin final notunu giriniz: ");
            final = Convert.ToInt32(Console.ReadLine());

            ortalama = (vize*40) + (final*60/100);

            if (ortalama>=gNot)
            {
                Console.WriteLine($"Geçtininiz, ortalamanız: {ortalama}");
            }

            else
            {
                Console.WriteLine($"Başarısız oldunuz, ortalamanız : {ortalama}");
            }
            Console.ReadLine();

            //Bu program ile ondalık işlem yapılamaz. *Double ile düzenleyebiliriz.*
        }
    }
}
