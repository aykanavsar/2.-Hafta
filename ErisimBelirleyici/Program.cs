using System.Runtime.InteropServices;

public int Topla(int a, int b)
{
    return a + b;

}

public class HesapMakinesi
{
    private int Carp(int a, int b)
    {
        return a * b;
    }
    public int ToplaveCarp(int a, int b)
    {
        int toplam = a + b;
        return Carp(toplam, b);
    }
}