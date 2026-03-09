using System;

class Program
{
    static void Main()
    {
        int[] arrayGenap = {2,4,6,8,10 };
        int number = 1;

        foreach(int angka in arrayGenap)
        {
            Console.WriteLine($"Angka genap ke {number} : {angka}");
            number++;
        }
        
    }
}