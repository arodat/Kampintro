using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç İçin Temel Kurs";
            string kurs3 = "Java Kursu";

            //array - dizi

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı",
                "Programlamaya Başlangıç İçin Temel Kurs",
                "Java Kursu",
                "Python",
                "Arif",
                "Kovan"
            };

            for (int i = 0; i < kurslar.Length; i+=2)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("-------------------");

            foreach (string ak in kurslar)
            {
                Console.WriteLine(ak);
            }

            Console.WriteLine("---------------------");
            Console.WriteLine("Sayfa Sonu - Footer");
        }
    }
}
