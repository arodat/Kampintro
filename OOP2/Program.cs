using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arif Kovan
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Arif";
            musteri1.Soyadi = "Kovan";
            musteri1.TcNo = "11112222333";

            //Yılport
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Yılport";
            musteri2.VergiNo = "12345678901";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            musteriManager.Add(musteri3);
            musteriManager.Add(musteri4);
            


            //Gerçek - Tüzel Müşteri
        }
    }
}
