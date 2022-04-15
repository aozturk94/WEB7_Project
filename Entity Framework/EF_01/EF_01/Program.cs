using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //ToList ile bölümleri listeliyoruz.
            void BolumlerListele()
            {
                HastaneAksamEntities hastane = new HastaneAksamEntities();
                var bolumler = hastane.Bolumler.ToList();
                Console.WriteLine("Bölüm ID\tBölüm Ad");
                foreach (var bolum in bolumler)
                {
                    Console.WriteLine($"{bolum.ID}\t\t{bolum.BolumAd}");
                }
                Console.ReadKey();
            }
            //BolumlerListele();

            //BölümGetir, Where ile
            void DoktorGetir()
            {
                using (HastaneAksamEntities hastane = new HastaneAksamEntities())
                {
                    var doktorlar = hastane.Doktorlar.Where(x => x.AdSoyad == "Sedat Kanar");

                    Console.WriteLine($"ID\tSİCİL NO\tAD SOYAD\tTEL\t\tBÖLÜM");
                    foreach (var doktor in doktorlar)
                    {
                        Console.WriteLine($"{doktor.ID}\t{doktor.SicilNo}\t\t{doktor.AdSoyad}\t{doktor.Tel}\t{doktor.Bolumler.BolumAd}");
                    }
                }
                Console.ReadLine();
            }
            //DoktorGetir();

            //D ile başlayan bölümleri getir
            void BolumGetir()
            {
                using (HastaneAksamEntities hastane = new HastaneAksamEntities())
                {
                    var bolumler = hastane.Bolumler.Where(x => x.BolumAd.StartsWith("D"));
                    foreach (var bolum in bolumler)
                    {
                        Console.WriteLine($"{bolum.ID}-{bolum.BolumAd}");
                    }
                }
                Console.ReadLine();
            }
            //BolumGetir();

            //Doktor Ad Soyadlarını Listele
            void DoktorAdSoyadListele()
            {
                using (HastaneAksamEntities hastane = new HastaneAksamEntities())
                {
                    var doktorAdlari = hastane.Doktorlar.Select(x => x.AdSoyad);
                    foreach (var doktorAd in doktorAdlari)
                    {
                        Console.WriteLine(doktorAd);
                    }
                }
                Console.ReadLine();
            }
            //DoktorAdSoyadListele();

            //Find ile hızlı arama
            void HizliAra()
            {
                using (HastaneAksamEntities hastane = new HastaneAksamEntities())
                {
                    //Find sadece ilgili entity'nin primary key'i üzerinde arama yapar.
                    Doktorlar doktor = hastane.Doktorlar.Find(4);
                    Console.WriteLine($"Ad: {doktor.AdSoyad}, Bölüm: {doktor.Bolumler.BolumAd}");
                }
                Console.ReadLine();
            }
            //HizliAra();

            //Doktorlardan ilk kaydı getir.
            void IlkDoktoruGetir()
            {
                using (HastaneAksamEntities hastane = new HastaneAksamEntities())
                {
                    Doktorlar doktor = hastane.Doktorlar
                    .Where(x => x.AdSoyad == "Demet Evgar")
                    .First();
                    Console.WriteLine($"{doktor.AdSoyad}, {doktor.Bolumler.BolumAd}");
                }
                Console.ReadLine();
            }
            //IlkDoktoruGetir();

            //Ilk üç doktoru getir
            void IlkUcDoktorListele()
            {
                using (HastaneAksamEntities hastane = new HastaneAksamEntities())
                {
                    var ilkUcDoktor = hastane.Doktorlar.Take(3);
                    foreach (var doktor in ilkUcDoktor)
                    {
                        Console.WriteLine(doktor.AdSoyad);
                    }
                }
                Console.ReadLine();
            }
            //IlkUcDoktorListele();

            //Demet Evgar adında bir doktor var mı?
            void DemetEvgarVarmi()
            {
                using (HastaneAksamEntities hastane = new HastaneAksamEntities())
                {
                    bool sonuc = hastane.Doktorlar.Any(x=>x.AdSoyad == "Demet Evgar");
                    if (sonuc)
                    {
                        Console.WriteLine("Aradığınız doktor var.");
                    }
                    else
                    {
                        Console.WriteLine("Hastanemizde böyle bir doktor bulunmamaktadır.");
                    }
                }
                Console.ReadLine();
            }
            //DemetEvgarVarmi();

            //Tüm doktorlar ortopedi bölümünde mi çalışıyor?
            void HepsiOrtopediMi()
            {
                using (HastaneAksamEntities hastane = new HastaneAksamEntities())
                {
                    bool sonuc = hastane.Doktorlar.All(x => x.Bolumler.BolumAd == "Ortopedi");
                    if (sonuc)
                    {
                        Console.WriteLine("Evet saçma bir şekilde hepsi ortopedi.");
                    }
                    else
                    {
                        Console.WriteLine("Hayır hepsi ortopedi değil!");
                    }
                }
                Console.ReadLine();
            }
            //HepsiOrtopediMi();

            //Doktorları A'dan Z'ye adına göre sıralayalım
            void DoktorSiralaAsc()
            {
                using (HastaneAksamEntities hastane = new HastaneAksamEntities())
                {
                    var siraliDoktorlar = hastane.Doktorlar.OrderBy(x => x.AdSoyad);
                    foreach (var doktor in siraliDoktorlar)
                    {
                        Console.WriteLine(doktor.AdSoyad);
                    }
                }
                Console.ReadLine();
            }
            //DoktorSiralaAsc();

            //Doktorları Z'dan A'ye adına göre sıralayalım
            void DoktorSiralaDesc()
            {
                using (HastaneAksamEntities hastane = new HastaneAksamEntities())
                {
                    var siraliDoktorlar = hastane.Doktorlar.OrderByDescending(x => x.AdSoyad);
                    foreach (var doktor in siraliDoktorlar)
                    {
                        Console.WriteLine(doktor.AdSoyad);
                    }
                }
                Console.ReadLine();
            }
            //DoktorSiralaDesc();

            //SORU: Diş Bölümünde çalışan doktor adlarını A'dan Z'ye sıralı şekilde listeleyin.
            void DoktorSiralaSoru()
            {
                using (HastaneAksamEntities hastane = new HastaneAksamEntities())
                {
                    var siraliDoktorlar = hastane.Doktorlar.Where(x=>x.Bolumler.BolumAd == "Diş").OrderBy(y => y.AdSoyad);
                    foreach (var doktor in siraliDoktorlar)
                    {
                        Console.WriteLine(doktor.AdSoyad);
                    }
                }
                Console.ReadLine();
            }
            //DoktorSiralaSoru();

            //Bölümlere göre çalışan doktor sayısını göster
            void BolumlereGoreDoktorSayisiniGoster()
            {
                using (HastaneAksamEntities hastane = new HastaneAksamEntities())
                {
                    var sonuc = hastane.Doktorlar
                        .GroupBy(x => x.Bolumler.BolumAd)
                        .Select(y => new
                        {
                            name = y.Key,
                            count = y.Count()
                        });

                    Console.WriteLine($"BÖLÜM\t\tDOKTOR SAYISI");
                    foreach (var bolum in sonuc)
                    {
                        Console.WriteLine($"{bolum.name}\t\t{bolum.count}");
                    }
                }
                Console.ReadLine();
            }
            //BolumlereGoreDoktorSayisiniGoster();

            //Sadece count görmek istediğimizde name=y.Key satırını kaldırdık.
            void BolumSayisiniGoster()
            {
                using (HastaneAksamEntities hastane = new HastaneAksamEntities())
                {
                    var sonuc = hastane.Doktorlar
                        .GroupBy(x => x.Bolumler.BolumAd).Select(y => new
                        {
                            count = y.Count()
                        });

                    foreach (var bolum in sonuc)
                    {
                        Console.WriteLine(bolum.count);
                    }
                }
                Console.ReadLine();
            }
            //BolumSayisiniGoster();

            //ÖDEV: New yapmadan aynı işi yapınız.

        }
    }
}
