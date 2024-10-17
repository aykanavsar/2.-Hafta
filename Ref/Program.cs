/*
void IkikatinaCikar(ref int sayi)
{
    sayi *= 2;

}

int deger = 5;
IkikatinaCikar(ref deger);
Console.WriteLine($"Deger : {deger}");
*/
/*
void DegerleriDegistir(ref int a, ref int b)
{
    int temp = a;
    a = b;
    b = temp;

}

int sayi1 = 10;
int sayi2 = 20;
DegerleriDegistir(ref sayi1, ref sayi2);
Console.WriteLine($"Sayi 1: {sayi1}");

Console.WriteLine($"Sayı 2: {sayi2}");
*/
/*

void DiziElemanlariniIkiKatinaCikar(ref int[] dizi)
{
    for (int i = 0; i < dizi.Length; i++)
    {
        dizi[i] *= 2;

    }
}

int[] sayilar = { 1, 2, 3, 4 };
DiziElemanlariniIkiKatinaCikar(ref sayilar);

Console.WriteLine($"Dizi: {string.Join(", ", sayilar)}");
*/
using System.Reflection;

void Fiyatguncelle(ref double fiyat, double yuzde)
{
    fiyat += fiyat * (yuzde / 100);
}

double urunFiyat = 100.0;
Fiyatguncelle(ref urunFiyat, 18);
Console.WriteLine($"Fiyat : {urunFiyat}");  
