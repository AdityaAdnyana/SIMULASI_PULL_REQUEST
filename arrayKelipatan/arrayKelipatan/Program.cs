using System;
//update

class Program
{
    public static void Main(string[] args)
    {
        for (int i = 1; i <= 50; i++)
        {
            if (i % 2 == 0 && i % 3 == 0)
            {
                Console.WriteLine($"{i} #$#$");
            }
            else if (i % 2 == 0)
            {
                Console.WriteLine($"{i} ##");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine($"{i} $$");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}