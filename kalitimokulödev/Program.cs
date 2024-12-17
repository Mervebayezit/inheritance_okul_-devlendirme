using System;

namespace Okulaçıklaması
{
   
    public class Kisi
    {
        public string ad { get; set; }
        public int yas { get; set; }
        public string cinsiyet { get; set; }
    }

    public class ogrenci : Kisi
    {
        public int ogrencino { get; set; }
        public string bolum { get; set; }
        public string sinif { get; set; }
    }

    public class ogretmen : Kisi
    {
        public string ders { get; set; }
    }

    public class gorev
    {
        public string ders { get; set; }
        public string odev { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ogrenci ogrenci = new ogrenci
            {
                ad = "Merve Bayezit",
                yas = 19,
                cinsiyet = "Kız",
                ogrencino = 656565,
                bolum = "Bilgisayar Mühendisliği",
                sinif = "2"
            };

            ogretmen ogretmen = new ogretmen
            {
                ad = "Ahmet Burak",
                yas = 25,
                cinsiyet = "Erkek",
                ders = "Veri Yapıları"
            };

            gorev gorev = new gorev
            {
                ders = "Veri Yapıları",
                odev = "Bubble sort algoritmasını oluşturunuz."
            };

            Console.WriteLine("Öğrenci Bilgileri:");
            Console.WriteLine("İsim:" +ogrenci.ad);
            Console.WriteLine("Yaş:" +ogrenci.yas);
            Console.WriteLine("Cinsiyet:" +ogrenci.cinsiyet);
            Console.WriteLine("Numara:" +ogrenci.ogrencino);
            Console.WriteLine("Bölüm:" +ogrenci.bolum);
            Console.WriteLine("Sınıf:" +ogrenci.sinif);

            Console.WriteLine("\nÖğretmen Bilgileri:");
            Console.WriteLine("İsim:" +ogretmen.ad);
            Console.WriteLine("Yaş:" +ogretmen.yas);
            Console.WriteLine("Cinsiyet:" +ogretmen.cinsiyet);
            Console.WriteLine("Ders:" +ogretmen.ders);

            Console.WriteLine("\nÖdev Bilgileri:");
            Console.WriteLine("Ders:" +gorev.ders);
            Console.WriteLine("Açıklama:" +gorev.odev);
        }
    }
}