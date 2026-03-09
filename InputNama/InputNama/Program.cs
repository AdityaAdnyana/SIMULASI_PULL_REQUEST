using System;

namespace InputNama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan nama Anda: ");
            string nama = Console.ReadLine();
            Console.WriteLine($"Sekamat datang , {nama}!");
        }
    }
}