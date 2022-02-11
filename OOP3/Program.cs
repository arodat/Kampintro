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
            

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(tasitKrediManager, fileLoggerService);

            Console.WriteLine("---------------------------");

            basvuruManager.BasvuruYap(new EsnafKrediManager(), new SmsLoggerService());

            Console.WriteLine("---------------------------");

            //Ternary operation
            int x = 10, y = 20;
            var result = x > y ? "Ternary - x büyük" : "Ternary - y büyük";
            Console.WriteLine(result);

            Console.WriteLine("---------------------------");

            int i = 0;
            while (i<=20)
            {
                Console.WriteLine(i);
                i++;
            }

            List<IKrediManager> krediler = new List<IKrediManager>(){ihtiyacKrediManager, tasitKrediManager};
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
