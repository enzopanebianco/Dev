using System;

namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Graus:");
            float grau = float.Parse(Console.ReadLine());

            float faren = (9* grau + 160) /5;

            Console.WriteLine($"Farenheit: {faren}");

        }
    }
}
