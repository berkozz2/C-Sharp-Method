using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Product urun1 = new Product();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";
            urun1.stokAdedi = 19;

            Product urun2 = new Product();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";
            urun2.stokAdedi = 13;

            Product[] products = new Product[] {urun1, urun2 };

            //type safe -- tip güvenlidir csharp
            //encapsulation

            foreach (Product product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine(product.stokAdedi);
                Console.WriteLine("-----------------");
            }

            Console.WriteLine("-----------Metodlar-------------");

            //instance - örnek
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 12, 9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12, 8);

        }
    }
}



//tekrar edecek kullanacak kodların varsa bunları metotlar haline getirebilmeliyiz. 
//dont repeat yourself - Clean code - Best Practice
//Id bir datayı ayırt etmek için kullanılır. Id değeri o yüzden kullanılır.
