using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {

            //Interface kendini implemente eden class ın referans numarasını tutabilir.

            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManger = new KonutKrediManger();

            BasvuruManager basvuruManager = new BasvuruManager();


            basvuruManager.BasvuruYap(konutKrediManger);
            Console.WriteLine("---------------------------");



            List<IKrediManager> krediler = new List<IKrediManager>(){ihtiyacKrediManager, tasitKrediManager};
            basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
