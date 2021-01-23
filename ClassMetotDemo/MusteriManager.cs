using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
           if (musteri.Cinsiyet ==false)
            {
                Console.WriteLine(musteri.AdSoyad + "Beyfendi Simulasyona Eklendi");
            }
            else
            {
                Console.WriteLine(musteri.AdSoyad + "Hanfendi Simulasyona Eklendi");
            }
            
        }
        public void EnUzunMusteri(Musteri musteri1, Musteri musteri2)
        {
            for (int i = 0; i < 1; i++)
            {
                Musteri max = musteri1;
                Console.WriteLine(max.AdSoyad);
                if (musteri2.Boy> musteri2.Boy)
                {
                    max = musteri2;
                }

            }
        }
    }
}
