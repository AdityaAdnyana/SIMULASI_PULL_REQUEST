using System;
public class Program
{
    public static void Main()
    {
        for (int i = 1; i < 6; i++)
        {
            int angka = 2;
            angka = angka * i;
            Console.WriteLine($"Angka genap {i} : {angka}");
        }
    }
}