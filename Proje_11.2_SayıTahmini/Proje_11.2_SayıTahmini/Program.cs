using System;

namespace Proje_11._2_SayıTahmini
{
    class Program
    {

        static void Main(string[] args)
        {
            {
                {
                    int SayiBul()
                    {
                        Random rnd = new Random();
                        int sayi = rnd.Next(1, 100);
                        Console.WriteLine(sayi);
                        return sayi;
                    }
                    int SayiTahmin()
                    {
                        Console.Write("Sayı giriniz: ");
                        int tahmin = int.Parse(Console.ReadLine());
                        return tahmin;
                    }
                    string a = "";
                    do
                    {
                        //int tahminSayisi = 5;
                        int random = SayiBul();
                        for (int i = 1; i <= 5; i++)
                        {
                            int tahmin = SayiTahmin();
                            if (tahmin < random && i != 5)
                            {
                                Console.WriteLine("Sayıyı Arttırınız!");
                                //Console.WriteLine($"{4 - i} hakkınız kaldı!");

                            }
                            else if (tahmin > random && i != 5)
                            {
                                Console.WriteLine("Sayıyı Küçültünüz!");
                                //Console.WriteLine($"{4-i} hakkınız kaldı!");
                            }
                            else if (tahmin == random)
                            {
                                Console.WriteLine("Doğru Bildiniz!");
                                Console.WriteLine($"Puanınız: {50 - i * 10}");
                                break;
                            }
                            if (i == 5 && random != tahmin)
                            {
                                Console.WriteLine("Hakkınız Bitti!");
                            }
                            //Console.WriteLine($"Kalan puanınız: {50 - i * 10}");
                        }
                        //Console.Clear();
                        Console.WriteLine("Oyuna devam etmek ister misiniz [Y]/[N]?");
                        a = Console.ReadLine();
                        Console.Clear();
                    } while (a != "N");
                    //Console.ReadLine();

                }
            }
        }

    }
}
