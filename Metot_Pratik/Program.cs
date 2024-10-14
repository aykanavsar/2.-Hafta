

using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("İsminizi girin:");
        string isim = Console.ReadLine();

        Console.WriteLine("Soyisminizi girin:");
        string soyisim = Console.ReadLine();    


    }

    public void IsimYazdir(string isim, string soyisim)
    {
        Console.WriteLine($"İsim: {isim}, Soyisim: {soyisim}");
    }
}