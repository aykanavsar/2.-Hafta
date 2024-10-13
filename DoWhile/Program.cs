/*
do
{
    //
}
while (koşul);
*/

int secim = 0;
do
{
    Console.WriteLine("1. seçenek");
    Console.WriteLine("2. seçenek");
    Console.WriteLine("0. çıkış");

    Console.WriteLine("bir seçim yapın");

    secim = int.Parse(Console.ReadLine());

    switch (secim)
    {
        case 1:
            Console.WriteLine("1 seçtiniz");
            break;

        case 2:
            Console.WriteLine("2 seçtiniz");
            break;
        case 0:

            Console.WriteLine("çıkış seçildi");
            break;
        default:
            Console.WriteLine("geçersiz");
            break;

    }

}
while (secim != 0);

Console.WriteLine("çıkış yapıldı...");

