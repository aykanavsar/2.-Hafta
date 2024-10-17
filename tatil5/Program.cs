

        string lokasyon = "";
        string secilenlokasyon = "";
        int lokasyonfiyat = 0;

for (lokasyonfiyat != 0)
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


            Console.WriteLine($"Teşekkürler, tatil için {secilenlokasyon}. \n{secilenlokasyon} için günlük kişi başı fiyarımız : {lokasyonfiyat}");
        }
Console.WriteLine($"Teşekkürler, tatil için {secilenlokasyon}. \n{secilenlokasyon} için günlük kişi başı fiyarımız : {lokasyonfiyat}");
        }
