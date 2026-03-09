using System;
public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Masukkan bilangan :");
        int bilangan = Convert.ToInt32(Console.ReadLine());
        if (bilPrima(bilangan))
        {
            Console.WriteLine($"{bilangan} adalah bilangan prima");
        }
        else
        {
            Console.WriteLine($"{bilangan} Bukan bilangan prima");
        }
    }

    public static bool bilPrima(int n)
    {
        if (n <= 1)
        {
            return false;
        }
        if (n <= 3)
        {
            return true;
        }
        if (n % 2 == 0 || n % 3 == 0)
        {
            return false;
        }
        for (int i = 5; i * i <= n; i += 6)
        {
            if (n % i == 0 || n % (i + 2) == 0)
            {
                return false;
            }
        }
        return true;
    }
}