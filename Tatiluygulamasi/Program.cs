// Yol Arkadaşım Programı

bool devam;

do
{
    string lokasyon = "";
    int lokasyonfiyat = 0;

    while (lokasyonfiyat == 0)
    {
        Console.WriteLine("Lütfen gitmek istediğimiz lokasyonu seçiniz. \nBodrum, Marmaris, Çeşme");
        lokasyon = Console.ReadLine().Trim().ToLower();

        if (lokasyon == "bodrum")
        {
            lokasyonfiyat = 4000;
        }

        else if (lokasyon == "marmaris")
        {
            lokasyonfiyat = 3000;

        }

        else if (lokasyon = "çeşme")
        {
            lokasyonfiyat = 5000;
        }

        else
        {
            Console.WriteLine("Hatalı lokasyon girdiniz. Lütden Bodrum, Marmaris, Çeşme lokasyonlarından birini seçiniz.");
        }



    }

}







