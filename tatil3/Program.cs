
string lokasyon = "";
int lokasyonfiyat = 0;
int kontrol = 0;
Console.WriteLine("Merhaba,\nLütfen gitmek istediğiniz lokasyonu seçiniz.\nBodrum, Marmaris, Çeşme");
lokasyon = Console.ReadLine().ToLower();


while (kontrol == 777)
{

    

    



    switch (lokasyon)
    {
        case "bodrum":
            Console.WriteLine("Tatil için Bodrumu tercih ettiniz,\nGünlük kişi başı tatil fiyatımız: 4000 TL' dir");
            lokasyonfiyat = 4000;
            break;

        case "marmaris":
            Console.WriteLine("Tatil için Marmarisi tercih ettiniz,\nGünlük kişi başı tatil fiyatımız 3000TL' dir ");
            lokasyonfiyat = 3000;
            break;

        case "çeşme":
            Console.WriteLine("Tatil için Çeşme tercih ettiniz,\nGünlük kişi başı tatil fiyatımız 5000TL' dir ");
            lokasyonfiyat = 5000;
            break;

        default:
            Console.WriteLine("Yanlış bir seçim yaptınız,");
            kontrol = 777;
            break;






    }
    Console.WriteLine("nedir"+ kontrol);
}

