/*
public int Topla(int a, int b)
{
    int toplam = a + b;
    return toplam;
}


public void Selamver()
{
    Console.WriteLine("Merhaba");
}
*/

double OrtalamaHesapla(int[] notlar)
{
    int toplam = 0;
    for (int i = 0; i < notlar.Length; i++)
    {
        toplam = toplam + notlar[i];
    }

    double ortalama = (double)toplam / notlar.Length;
    return ortalama;

}

Console.WriteLine(OrtalamaHesapla(new int[] { 10,50, 100 }));
