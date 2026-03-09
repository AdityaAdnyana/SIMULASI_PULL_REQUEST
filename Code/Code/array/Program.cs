using System;
public class Program
{
    public static void Main()
    {
        for (int i = 0; i <= 50; i++)
        {
            if (i == 0)
            {
                Console.WriteLine($"{i} #$#$");
            }
            else if (i % 2 == 0 && i % 3 == 0)
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
            else if (i % 2 != 0 || i % 3 != 0)
            {
                Console.WriteLine(i);
            }
        }

    }
}