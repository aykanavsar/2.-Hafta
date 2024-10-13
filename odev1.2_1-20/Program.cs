

int tek = 0;
int cift = 0;
for (int i = 0; i < 21; i ++)
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
