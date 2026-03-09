using System;

namespace inputCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("masukan huruf :");
            char input = Console.ReadKey().KeyChar;
            char huruf = char.ToLower(input);
            

            if (huruf == 'a' || huruf == 'i' || huruf == 'u' || huruf == 'e' || huruf == 'o')
            {
               Console.WriteLine($"\n huruf {huruf} adalah huruf volal");
            }
            else
            {
                Console.WriteLine($"\n huruf {huruf} adalah huruf konsonan");
            }

            Console.WriteLine("masukan huruf :");
            char input2 = Console.ReadKey().KeyChar;
            char huruf2 = char.ToLower(input2);


            if (huruf2 == 'a' || huruf2 == 'i' || huruf2 == 'u' || huruf2 == 'e' || huruf2 == 'o')
            {
                Console.WriteLine($"\n huruf {huruf2} adalah huruf volal");
            }
            else
            {
                Console.WriteLine($"\n huruf {huruf2} adalah huruf konsonan");
            }
        }
    }
}