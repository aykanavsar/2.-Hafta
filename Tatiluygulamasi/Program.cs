using System;

namespace Tatil_Uygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            int b = 0;
            Console.WriteLine("Bodrum : Paket başlangıç fiyatı 4.000 TL");
            Console.WriteLine("Marmaris : Paket başlangıç fiyatı 3.000 TL");
            Console.WriteLine("Çeşme : Paket başlangıç fiyatı 5.000 TL");
            do
            {
                
                Console.WriteLine("Merhaba,yukarıda sizlere hizmet verdiğimiz lokayonlar listelenmiştir. \nLütfen gitmek istediğiniz lokasyonu seçiniz.");
                string a = Console.ReadLine().ToLower();

                switch (a)
                {
                    case "bodrum":
                        Console.WriteLine("Bodrum Peketini Seçtiniz");
                        int b += 4000;
                        break;
                    case "marmaris":
                        Console.WriteLine("Marmaris Paketini Seçtiniz");
                        int b += 3000;
                        break;
                    case "çeşme":
                        Console.WriteLine("Çeşme Paketini Seçtiniz");
                        int b += 5000;
                        break;

                    default:
                        Console.WriteLine("Lütfen ");
                        break;



                }




            }
            
           
            
        }
    }
}
