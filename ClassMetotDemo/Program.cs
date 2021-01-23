using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.AdSoyad = "Engin Demirog";
            musteri1.Boy =1.86;
            musteri1.Id = 1254684;
            musteri1.Cinsiyet = false;


            Musteri musteri2 = new Musteri();
            musteri2.AdSoyad = "Ayşe Demir";
            musteri2.Boy = 1.55;
            musteri2.Id = 6545613;
            musteri2.Cinsiyet = true;

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

            musteriManager.EnUzunMusteri(musteri1, musteri2);

        }
    }
}
