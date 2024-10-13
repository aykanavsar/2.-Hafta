/*
string yazi  = "Kendime inanıyorum, ben bu yazılım işini hallederim!";
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"{yazi}");
}

for (int i = 1; i < 21; i++)
{
   Console.WriteLine($"sayı : {i}");
}

for (int i = 0; i < 21; i += 2)
{
    Console.WriteLine($"Çift Sayılar: {i}");
  }

int toplam = 0;
for (int i = 50; i <= 150; i++)
{
    toplam += i;
}
Console.WriteLine("50 ile 150 arasındaki sayıların toplamı = " + toplam);
*/

int tek = 0;
int cift = 0;
for (int i = 0; i < 21; i++)
{
    if (i % 2 == 0)
    {
        tek += i;
    }
    else
    {
        cift += i;
    }
}

Console.WriteLine("0 ile 20 arasındaki çift sayıların toplamı =" + cift);
Console.WriteLine("0 ile 20 arasındaki tek sayıların toplamı =" + tek);

