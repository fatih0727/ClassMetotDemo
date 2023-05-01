using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();//musteri1 olustu
            musteri1.Id = 1;    musteri1.Ad = "Fatih"; musteri1.Soyad = "Demiraran";
            Musteri musteri2 = new Musteri();//musteri2 olustu
            musteri2.Id = 2; musteri2.Ad = "Caner"; musteri2.Soyad = "Mülayim";
            Musteri musteri3 = new Musteri();//musteri3 olustu
            musteri3.Id = 3; musteri3.Ad = "Mert"; musteri3.Soyad = "Karatekin";
            
            MusteriManager musteriManager = new MusteriManager();//MusteriManager classına ulasmam gerekiyor

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 }; // musterileri listelemek için gerekli.

            Console.WriteLine("....................Musteri Listele....................");
            musteriManager.MusteriListele(musteriler);
            Console.WriteLine("----------------------");
            Console.WriteLine("....................Müşteri Ekleme....................");
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriEkle(musteri3);
            Console.WriteLine("----------------------");
            Console.WriteLine("....................Müşteri Silme....................");
            musteriManager.MusteriSil(musteri1);
            musteriManager.MusteriSil(musteri2);
            musteriManager.MusteriSil(musteri3);
            Console.WriteLine("------------------------");
        }
    }
}
