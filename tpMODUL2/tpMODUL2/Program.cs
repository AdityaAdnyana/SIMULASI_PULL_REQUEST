using System;
public class Program
{
    public static void Main()
    {
        Console.Write("Masukan huruf : ");
        string input = Console.ReadLine();
        
        switch (input.ToUpper())
        {
            case "A":
                Console.WriteLine($"Huruf {input} merupakan huruf vokal");
                break;
            case "I":
                Console.WriteLine($"Huruf {input} merupakan huruf vokal");
                break;
            case "U":
                Console.WriteLine($"Huruf {input} merupakan huruf vokal");
                break;
            case "E":
                Console.WriteLine($"Huruf {input} merupakan huruf vokal");
                break;
            case "O":
                Console.WriteLine($"Huruf {input} merupakan huruf vokal");
                break;
            default:
                Console.WriteLine($"Huruf {input} merupakan huruf konsonan");
                break;
        }

    }
}