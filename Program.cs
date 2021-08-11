using System;

namespace ConsoleProgramlama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            System.Console.WriteLine("Ad : ");
            string name = Console.ReadLine();
            System.Console.WriteLine("Soyad : ");
            string surname = Console.ReadLine();

            System.Console.WriteLine("Merhaba " + name + " " + surname);
        }
    }
}
