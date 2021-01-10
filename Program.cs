using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            // // Kullanıcıdan 10 adet sayı girilmesi istenir ve girilen sayılardan büyük sayı, küçük sayı ve girilen sayıların ortalamasının çıktısını vermesi istendi.
            int BuyukSayi, KucukSayi; // değişkenler tanımlanır
            double toplam = 0, ortalama = 0;
            //Girilen sayılar listeye eklenir.
            List<int> sayilar = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                Console.Write((i + 1) + ". sayıyı giriniz:"); //ekrana kaçıncı sayı ise onun gösterilmesi istendi
                int sayi = Convert.ToInt32(Console.ReadLine());
                sayilar.Add(sayi);
                toplam += sayi;
            }
            ortalama = toplam / 10;
            //ilk değerler atanır.
            BuyukSayi = sayilar[0];
            KucukSayi = sayilar[0];
            //en büyük ve en küçük sayı için kontrol edilir.
            foreach (int sayi in sayilar)
            {
                if (sayi > BuyukSayi)
                {
                    BuyukSayi = sayi;
                }
                if (sayi < KucukSayi)
                {
                    KucukSayi = sayi;
                }

            }
            Console.WriteLine("En Büyük Sayı: {0}", BuyukSayi);
            Console.WriteLine("En Küçük Sayı: {0}", KucukSayi);
            Console.WriteLine("Ortalama: {0}", ortalama);

            Console.ReadLine();
        }
    }
}


