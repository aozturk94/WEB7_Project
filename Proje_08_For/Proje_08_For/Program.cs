using System;

namespace Proje_08_For
{
    class Program
    {
        static void Main(string[] args)
        {

            /*for (int i = 1; i <=5; i++)
            {
                Console.WriteLine($"{i}. Hello World!");
            }
            Console.ReadLine();*/
            /*int toplam = 0;
            for (int i = 1; i <= 10; i++)
            {
                if (i%2==0)
                {
                    Console.WriteLine(i);
                    toplam += i;

                }
            }*/

            /* int toplam = 0;
             for (int i = 2; i <= 10; i+=2)
             {
                 if (i%2==0)
                 {
                     Console.WriteLine(i);
                     toplam += i;

                 }
             }

             Console.WriteLine();
             Console.WriteLine($"Toplam: {toplam}");
             Console.ReadLine();*/


            /*1 ile 100 arasındaki asal sayıları ekrana yazdıran programı yazınız.*/

            /*          bool asal = true;  //!!!İkili durumlarda bool kullanmak kolaylık sağlar.!!!
                        for (int i = 2; i <=100; i++) //Asal olup olmadığını kontrol edeceğimiz sayıları temsil eden döngü.
                        {
                            for (int j = 2; j < i; j++) //"i" sayısının asal olup olmadığını kontrol etmek için kendisine kadar olan sayılara böldüğümüz döngü.
                            {
                                if (i%j==0)
                                {
                                    asal = false;
                                    break;
                                }
                            }

                            if (asal)
                            {
                                Console.WriteLine(i);
                            }

                            asal = true;
                        }

                        Console.ReadLine();*/
            /*int say = 0;
            int say2 = 0;
            int say3 = 0;
            bool asal = true;  //!!!İkili durumlarda bool kullanmak kolaylık sağlar.!!!
            for (int i = 2; i <= 300; i++) //Asal olup olmadığını kontrol edeceğimiz sayıları temsil eden döngü.
            {
                for (int j = 2; j < i; j++) //"i" sayısının asal olup olmadığını kontrol etmek için kendisine kadar olan sayılara böldüğümüz döngü.
                {
                    if (i % j == 0)
                    {
                        asal = false;
                        break;
                    }
                }

                if (asal)
                {
                    if (i<=100)
                    {
                        say++;
                    }

                    else if (i<=200)
                    {
                        say2++;

                    }

                    else
                    {
                        say3++;

                    }
                }
                asal = true;
            }

            Console.WriteLine();
            Console.WriteLine($"1 ile 100 arasındaki asal sayı adedi: {say}");
            Console.WriteLine($"100 ile 200 arasındaki asal sayı adedi: {say2}");
            Console.WriteLine($"200 ile 300 arasındaki asal sayı adedi: {say3}");
            Console.ReadLine();*/

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Title = "ÇARPIM TABLOSU";

            for (int i = 1; i <=10; i++)
            {
                for (int j = 1; j <=10; j++)
                {
                    Console.Write($"{i}x{j}={i*j}\t");
                }

                Console.WriteLine("\n");
            }

            Console.ReadLine();



        }
    }
}
