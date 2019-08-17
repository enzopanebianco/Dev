using System;

namespace exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mínima");
            float minima = float.Parse(Console.ReadLine());

            Console.WriteLine("Maxima");
            float maxima = float.Parse(Console.ReadLine());

            float media = (minima + maxima ) /2;
            Console.WriteLine($"Média:{media}");
        }
    }
}
