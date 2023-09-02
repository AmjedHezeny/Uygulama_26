using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama_26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> sayilar = new List<int>()
            {
                45, 6, 78, 300, 254, 96, -69, -450, 30, 625, 6452, 87, 6, -2, -521
            };

            
            Console.WriteLine("****************************************");
            Console.WriteLine("Linq Sorgulamaları.");
            Console.WriteLine("----------------------------------------");
            Console.Write("Sayılar: ");
            foreach (var item in sayilar)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();



            #region Take()
            Console.WriteLine("****************************************");
            Console.WriteLine();
            Console.WriteLine("****************************************");
            Console.WriteLine("Koleksiyon İçerisindeki Verilerin Sadece Belirtildiği Kadarını\r\nListeler () Parantez İçerisinde İnt Bir Değer Belirtilir.");
            Console.WriteLine("----------------------------------------");
            var takeListe = sayilar.Take(2);
            Console.Write("Take: ");
            foreach (var item in takeListe)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("****************************************");
            Console.WriteLine();
            #endregion


            #region Sum()
            Console.WriteLine("****************************************");
            Console.WriteLine("Koleksiyon İçerisindeki Verilerin Toplamını Alır.");
            Console.WriteLine("----------------------------------------");
            var toplam = sayilar.Sum(s => s);
            Console.WriteLine("Sayıların Toplamı = " + toplam);
            Console.WriteLine("****************************************");
            Console.WriteLine();
            #endregion




            #region Min()
            Console.WriteLine("****************************************");
            Console.WriteLine("Koleksiyon İçerisindeki Verilerden En Küçük Olanı Geri Verir.");
            Console.WriteLine("----------------------------------------");
            var enKucuk = sayilar.Min();
            Console.WriteLine("En Küçük Sayı = " + enKucuk);
            Console.WriteLine("****************************************");
            Console.WriteLine();
            #endregion




            #region Max()
            Console.WriteLine("****************************************");
            Console.WriteLine("Koleksiyon İçerisindeki En Büyük Olan Veriyi Geri Döndürür.");
            Console.WriteLine("----------------------------------------");
            var enBuyuk = sayilar.Max();
            Console.WriteLine("En Büyük Sayı = " + enBuyuk);
            Console.WriteLine("****************************************");
            Console.WriteLine();
            #endregion




            #region Any()
            Console.WriteLine("****************************************");
            Console.WriteLine("Koleksiyon İçerisinde Sorgulama Sonucunda\r\nHerhangi Bir Veri Var Mı Yok Mu Sorgulaması Yapar.");
            Console.WriteLine("----------------------------------------");
            var varMi = sayilar.Any(q => q >= 5000 && q <= 7000);
            Console.WriteLine(varMi ? "Değer Var" : "Değer Yok");
            Console.WriteLine("****************************************");
            Console.WriteLine();
            #endregion




            #region FirstOrDefault()
            Console.WriteLine("****************************************");
            Console.WriteLine("Koleksiyon İçerisinde Bulunan Değerlerden\r\nSorgulama Sonucunda İlk Değerini Geriye Döndürür.");
            Console.WriteLine("----------------------------------------");
            var firstOrDefault = sayilar.FirstOrDefault(s => s >= 25000);
            Console.WriteLine("İlk Sayı : " + firstOrDefault);
            Console.WriteLine("****************************************");
            Console.WriteLine();
            #endregion



            #region TakeWhile()
            Console.WriteLine("****************************************");
            Console.WriteLine("Koleksiyon İçerisindeki Verileri TakeWhile Metodu İçerisindeki\r\nKoşul Doğruluğu Sağlandığı Sürece Okuma İşlemi Yapar.");
            Console.WriteLine("----------------------------------------");
            var takeWhile = sayilar.TakeWhile(s => s <= 500);
            Console.Write("TakeWhile Metodu: ");
            foreach (var item in takeWhile)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.WriteLine("****************************************");
            Console.WriteLine();
            #endregion




            #region Average()
            Console.WriteLine("****************************************");
            Console.WriteLine("Koleksiyon İçerisinde Belirtilen Property nin Ortalamasını Alır.");
            Console.WriteLine("----------------------------------------");
            var ortalama = sayilar.Average();
            Console.WriteLine("Sayıların Ortalaması = " + ortalama);
            Console.WriteLine("****************************************");
            Console.WriteLine();
            #endregion




            #region Count()
            Console.WriteLine("****************************************");
            Console.WriteLine("Koleksiyon İçerisinde Bulunan Elemanların Toplam Sayısını Verir.");
            Console.WriteLine("----------------------------------------");
            var elemanSayisi = sayilar.Count(s => s < 500);
            Console.WriteLine("500'den Küçük Eleman Sayısı = " + elemanSayisi);
            Console.WriteLine("****************************************");
            Console.WriteLine();
            #endregion




            #region LastOrDefault()
            Console.WriteLine("****************************************");
            Console.WriteLine("Koleksiyonun Son Elemanını Döndürür.");
            Console.WriteLine("----------------------------------------");
            var lastOr = sayilar.LastOrDefault(s => s > 7000);
            Console.WriteLine("Son Sayı : " + lastOr);
            Console.WriteLine("****************************************");
            Console.WriteLine();
            #endregion





            #region ToList()
            Console.WriteLine("****************************************");
            Console.WriteLine("Koleksiyon İçerisindeki Verileri List Yapısına Döndürür.");
            Console.WriteLine("----------------------------------------");
            var list = sayilar.Where(s => s < 1000).ToList();
            Console.WriteLine("****************************************");
            Console.WriteLine();
            #endregion



            #region ToArray()
            Console.WriteLine("****************************************");
            Console.WriteLine("Koleksiyon İçerisindeki Verileri Array Yapısına Döndürür.");
            Console.WriteLine("----------------------------------------");
            var array = sayilar.Where(s => s < 1000).ToArray();
            Console.WriteLine("****************************************");
            Console.WriteLine();
            #endregion

            Console.ReadKey();
        }
    }
}
