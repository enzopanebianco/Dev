using System;

namespace Senai.Exemplo.Variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração das variaveis
            string Nome;
            byte Idade;
            float Altura;
            char Sexo;
            DateTime dataNascimento;

            Console.WriteLine("Informe seu nome");
            Nome = Console.ReadLine();

            Console.WriteLine("informe sua Idade"); 
            Idade = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Informe sua Altura");
            Altura = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe seu sexo");
            Sexo = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Informe sua Data de Nascimento");
            dataNascimento = Convert.ToDateTime(Console.ReadLine());


            Console.WriteLine("Nome: " + Nome + ", Idade: " + Idade + " Altura: " + Altura + " Sexo: " + Sexo + "  Data de Nascimento: " + dataNascimento.ToShortDateString() );

        }
    }
}
