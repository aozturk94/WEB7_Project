using System;

namespace Proje_04_Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------DATA TYPES----------");
            Console.WriteLine("A-Int(Integer)");
            Console.WriteLine("I-Unsigned Types");

            Console.WriteLine("1) byte: ");
            Console.WriteLine($"Minimum Değer          => {byte.MinValue}");
            Console.WriteLine($"Maksimum Değer         => {byte.MaxValue}");
            Console.WriteLine($"Boyut                  => {sizeof(byte)} byte");
            Console.WriteLine($"2'nin 8'inci kuvveti   => {Math.Pow(2,8)-1}");
            Console.WriteLine("------------------------------");

            Console.WriteLine("2) ushort: ");
            Console.WriteLine($"Minimum Değer          => {ushort.MinValue}");
            Console.WriteLine($"Maksimum Değer         => {ushort.MaxValue:0,00}");
            Console.WriteLine($"Boyut                  => {sizeof(ushort)} byte");
            Console.WriteLine($"2'nin 16'ncı kuvveti   => {Math.Pow(2, 16) - 1:0,00}"); //0:00 basamakları ayırmak için.
            Console.WriteLine("------------------------------");

            Console.WriteLine("3) uint: ");
            Console.WriteLine($"Minimum Değer          => {uint.MinValue}");
            Console.WriteLine($"Maksimum Değer         => {uint.MaxValue:0,00}");
            Console.WriteLine($"Boyut                  => {sizeof(uint)} byte");
            Console.WriteLine($"2'nin 16'ncı kuvveti   => {Math.Pow(2, 32) - 1:0,00}"); //0:00 basamakları ayırmak için.
            Console.WriteLine("------------------------------");

            Console.WriteLine("4) ulong: ");
            Console.WriteLine($"Minimum Değer          => {ulong.MinValue}");
            Console.WriteLine($"Maksimum Değer         => {ulong.MaxValue:0,00}");
            Console.WriteLine($"Boyut                  => {sizeof(ulong)} byte");
            Console.WriteLine("------------------------------");

            Console.WriteLine("II-Signed Types");
            Console.WriteLine("1) sbyte: ");
            Console.WriteLine($"Minimum Değer          => {sbyte.MinValue}");
            Console.WriteLine($"Maksimum Değer         => {sbyte.MaxValue}");
            Console.WriteLine($"Boyut                  => {sizeof(sbyte)} byte");
            Console.WriteLine("------------------------------");

            Console.WriteLine("2) short: ");
            Console.WriteLine($"Minumum Değer          =>{short.MinValue}");
            Console.WriteLine($"Maksimum Değer         =>{short.MaxValue}");
            Console.WriteLine($"Boyut                  =>{sizeof(short)} byte");
            Console.WriteLine("------------------------------");

            Console.WriteLine("3) int: ");
            Console.WriteLine($"Minumum Değer          =>{int.MinValue}");
            Console.WriteLine($"Maksimum Değer         =>{int.MaxValue}");
            Console.WriteLine($"Boyut                  =>{sizeof(int)} byte");
            Console.WriteLine("------------------------------");

            Console.WriteLine("4) long: ");
            Console.WriteLine($"Minumum Değer          =>{long.MinValue}");
            Console.WriteLine($"Maksimum Değer         =>{long.MaxValue}");
            Console.WriteLine($"Boyut                  =>{sizeof(long)} byte");
            Console.WriteLine("------------------------------");

            Console.WriteLine("B) Ondalıklı Sayılar (Decimal)");
            Console.WriteLine("1) float: ");
            Console.WriteLine($"Minumum Değer          =>{float.MinValue}");
            Console.WriteLine($"Maksimum Değer         =>{float.MaxValue}");
            Console.WriteLine($"Boyut                  =>{sizeof(float)} byte");
            Console.WriteLine("------------------------------");

            Console.WriteLine("2) decimal: ");
            Console.WriteLine($"Minumum Değer          =>{decimal.MinValue}");
            Console.WriteLine($"Maksimum Değer         =>{decimal.MaxValue}");
            Console.WriteLine($"Boyut                  =>{sizeof(decimal)} byte");
            Console.WriteLine("------------------------------");

            Console.WriteLine("3) double: ");
            Console.WriteLine($"Minumum Değer          =>{double.MinValue}");
            Console.WriteLine($"Maksimum Değer         =>{double.MaxValue}");
            Console.WriteLine($"Boyut                  =>{sizeof(double)}  byte");
            Console.WriteLine("------------------------------");

            Console.WriteLine("C) bool (Logical)");
            Console.WriteLine($"Minumum Değer          =>{false}");
            Console.WriteLine($"Maksimum Değer         =>{true}");
            Console.WriteLine($"Boyut                  =>{sizeof(bool)} byte");
            Console.WriteLine("------------------------------");

            Console.WriteLine("D) char");
            Console.WriteLine($"Minumum Değer          =>{(int)char.MinValue}");
            Console.WriteLine($"Maksimum Değer         =>{(int)char.MaxValue}");
            Console.WriteLine($"Boyut                  =>{sizeof(char)} byte");

            //char kod;
            //kod = 'r';
            Console.WriteLine("------------------------------");

            Console.WriteLine("E) DateTime");
            Console.WriteLine($"Minumum Değer          =>{DateTime.MinValue}");
            Console.WriteLine($"Maksimum Değer         =>{DateTime.MaxValue}");

            unsafe //DateTime'ın RAM'de kapladığı boyutu öğrenmek için bu aşamayı uygulamalıyız. Bkz. ==> Unsafe, Pointer, DateTime
            {
                Console.WriteLine($"Boyut                  =>{sizeof(DateTime)} byte");
            }
            Console.WriteLine("------------------------------");


            Console.ReadLine();
        }
    }
}
