using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi:");
            Console.WriteLine("ID : "+musteri.Id);
            Console.WriteLine("AD : " + musteri.Ad);
            Console.WriteLine("SOYAD : " + musteri.Soyad);
        }
        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi:");
            Console.WriteLine("ID : " + musteri.Id);
            Console.WriteLine("AD : " + musteri.Ad);
            Console.WriteLine("SOYAD : " + musteri.Soyad);
        }
        public void MusteriListele(Musteri[] Musteriler)
        {
            Console.WriteLine("Müşteriler Listeleniyor...");
            foreach (Musteri musteri in Musteriler)
            {
                Console.WriteLine("ID : " + musteri.Id);
                Console.WriteLine("AD : " + musteri.Ad);
                Console.WriteLine("SOYAD : " + musteri.Soyad);
                Console.WriteLine("....");
            }
        }
    }
}
