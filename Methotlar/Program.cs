using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Id = 1;
            urun1.ProductName = "Dolma Kalem";
            urun1.Descrition = "Kaliteli mürekkebi ile dolma kalem";
            urun1.ProductPrice = 300;

            Urun urun2 = new Urun();
            urun2.Id = 2;
            urun2.ProductName = "Tükenmez Kalem";
            urun2.Descrition = "Mavi tükenmez kalem";
            urun2.ProductPrice = 50;
            
            Urun urun3 = new Urun();
            urun3.Id = 3;
            urun3.ProductName = "Uçlu Kalem";
            urun3.Descrition = "0.7 uçlu kalem";
            urun3.ProductPrice = 30;

            Urun urun4 = new Urun();
            urun4.Id = 4;
            urun4.ProductName = "Uçlu Kalem";
            urun4.Descrition = "0.5 uçlu kalem";
            urun4.ProductPrice = 30;

            Urun[] kalemler = new Urun[] { urun1, urun2, urun3, urun4 };
            foreach (var kalem in kalemler)
            {
                Console.WriteLine("Urun sıra no :" + kalem.Id);
                Console.WriteLine("Urun adı :" + kalem.ProductName);
                Console.WriteLine("Urun fiyatı :" + kalem.ProductPrice);
                Console.WriteLine("Urun açıklaması :" + kalem.Descrition);
                Console.WriteLine();
            }

            Console.WriteLine("---------------Methotlar--------------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(urun1);
            sepetManager.Add(urun2);
            sepetManager.Add(urun3);
            sepetManager.Add(urun4);



            Console.ReadLine();


        }
        
    }
}
