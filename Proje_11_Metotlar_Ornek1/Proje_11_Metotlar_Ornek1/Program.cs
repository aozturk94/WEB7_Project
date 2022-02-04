using System;

namespace Proje_11_Metotlar_Ornek1
{
    class Program
    {
        static void Main(string[] args)
        {
            int VeriGir(int sira)
            {
                Console.Write($"{sira}. sayıyı giriniz: ");
                int sayi = int.Parse(Console.ReadLine());
                return sayi;
            }
/*
            int Topla(int number1, int number2)
            {
                return number1 + number2;
            }

            int Cikar(int number1, int number2)
            {
                return number1 - number2;
            }
            int Carp(int number1, int number2)
            {
                return number1 * number2;
            }
            int Böl(int number1, int number2)
            {
                return number1 / number2;
            }*/


            int Islem(int number1, int number2, string islemTuru) //İçerde direk atarsak tür ya da sayi girilmezse o işlemi yapar ya da sayıyı alır.
            {
                if (islemTuru=="+")
                {
                    return number1 + number2;
                }

                else if (islemTuru=="-")
                {
                    return number1 - number2;
                }

                else if (islemTuru=="*")
                {
                    return number1 * number2;
                }

                else
                {
                    return number1 / number2;
                }

            }


            int sayi1 = VeriGir(1);
            int sayi2 = VeriGir(2);
            Console.WriteLine($"Sonuç: {Islem(sayi1,sayi2,"-")}");
            //Console.WriteLine($"Sonuç: {Islem(number1:sayi1,islemTuru:"*")}"); //Bu şekilde istediğimiz sırada yazabiliriz.

            /*Console.WriteLine(Topla(sayi1,sayi2));
            Console.WriteLine(Cikar(sayi1,sayi2));
            Console.WriteLine(Carp(sayi1,sayi2));
            Console.WriteLine(Böl(sayi1,sayi2));*/


            Console.ReadLine();

        }

    }
}
