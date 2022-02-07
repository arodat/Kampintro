#nullable enable
using System;
using System.Collections.Concurrent;
using System.Reflection.Emit;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Arif";
            int yas = 32;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.EgitmenAdi = "Arif KOVAN";
            kurs1.IzlenmeOrani = 75;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.EgitmenAdi = "Kerem";
            kurs2.IzlenmeOrani = 60;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.EgitmenAdi = "Berkay";
            kurs3.IzlenmeOrani = 80;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.EgitmenAdi = "Murat";
            kurs4.IzlenmeOrani = 50;

            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.EgitmenAdi);
            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3,kurs4 };
            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.EgitmenAdi + " : %" +kurs.IzlenmeOrani);
                
            }
        }
    }

    class Kurs
    {
        public string? KursAdi { get; set; }
        public string? EgitmenAdi { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
