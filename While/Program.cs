/*
while (koşul)
{
    //
}


int sayac = 0; 
while (sayac < 5)
{
    Console.WriteLine($"sayı {sayac}");
    sayac++;
}


string girdi = string.Empty;

while (girdi != "çıkış")
{
    Console.WriteLine("çıkmak için çıkış yazın");
    girdi = Console.ReadLine();
}
*/

Random  rand = new Random();

int hedef = rand.Next(1, 10);

int tahmin = 0;

while (tahmin != hedef)
{
    Console.WriteLine("Bir tahmin yapın");
    tahmin = int.Parse(Console.ReadLine());

    if (tahmin < hedef)
    {
        Console.WriteLine("daha büyük sayı girmelisin");
    }
    else if (tahmin > hedef)
    {
        Console.WriteLine("daha küçük bir sayı girmelisin");
    }
    else
    {
        Console.WriteLine("Tebrikler");
    }
}
