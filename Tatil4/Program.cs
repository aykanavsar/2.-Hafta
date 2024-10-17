

using System;

internal class Program
{
    private static void Main(string[] args)
    {
        string lokasyon = "";
        string secilenlokasyon = "";
        int lokasyonfiyat = 0;

        while (lokasyonfiyat == 0)
        {
            Console.WriteLine("Merhaba,\nLütfen gitmek istediğiniz lokasyonu seçiniz.\nBodrum, Marmaris, Çeşme");
            lokasyon = Console.ReadLine().ToLower();

            if (lokasyon == "bodrum")
            {

                lokasyonfiyat = 4000;
                secilenlokasyon = "Bodrum";
            }

            else if (lokasyon == "marmaris")
            {

                lokasyonfiyat = 3000;
                secilenlokasyon = "Marmaris";
            }

            else if (lokasyon == "çeşme")
            {

                lokasyonfiyat = 5000;
                secilenlokasyon = "Çeşme";

            }
            else
            {
                Console.WriteLine("Hatalı bir lokasyon girdiniz, tekrar deneyin");
            }

        }
        Console.WriteLine($"Teşekkürler, tatil için seçtiğiniz lokasyon {secilenlokasyon}" +
            $". \n{secilenlokasyon} için günlük kişi başı fiyatımız : {lokasyonfiyat}");


        int kisisayisi = 0;
        while (kisisayisi <= 0)
        {
            Console.WriteLine("Kaç kişi tatil yapmayı planlıyorsunuz : ");
            kisisayisi = int.Parse( Console.ReadLine() );
        }

        int ulasimsecim = 0;
        int ulasimfiyat = 0;    
        
        while (ulasimfiyat == 0)
        {
            Console.WriteLine("Ulaşımınızı nasıl yapmak istersiniz: \n1) Kara Yolu (1500TL)   2) Hava Yolu (4000TL)\n1 ya da 2 yazarak seçimizini yapın.");
            ulasimsecim = int.Parse(Console.ReadLine());
            if (ulasimsecim == 1)
            {
                Console.WriteLine("Ulaşım için Kara Yolunu tercih ettiniz.\nKara yolu kişi başı fiyatı 1500TL' dir.");
                ulasimfiyat = 1500;
            }
            else if (ulasimsecim == 2)
            {
                Console.WriteLine("Ulaşım için Hava Yolunu tercih ettiniz.\nHava yolu kişi başı fiyatı 4000TL' dir.");
                ulasimfiyat = 4000;
            }
            else
            {
                Console.WriteLine("Yanlış bir seçim yaptınız, lütfen aşağıda ki bilgilere göre seçim yapınız.");
            }
        }

        int toplamfiyat = 0;
        toplamfiyat = kisisayisi * (ulasimfiyat + lokasyonfiyat);
        
        Console.WriteLine("Bizi Tercih ettiğiniz için teşekkür ederi. Tatil planınız için fiyatımız: " + toplamfiyat);




    }
}
