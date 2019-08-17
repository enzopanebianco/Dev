using System;

namespace exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Imc Pessoa 1

            Console.WriteLine("Informe o peso da primeira pessoa");
            float pesoPessoa1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe a altura da primeira pessoa");
            float alturaPessoa1 = float.Parse(Console.ReadLine());

            float imcPessoa1 = pesoPessoa1 /( alturaPessoa1 * alturaPessoa1);



            Console.WriteLine(" Pessoa 1 pesa " + pesoPessoa1 + " e tem de altura " + alturaPessoa1 + " seu imc é " + imcPessoa1 );
           
            #endregion

            #region Imc Pessoa 2

            Console.WriteLine("Informe o peso da primeira pessoa 2");
            float pesoPessoa2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe a altura da primeira pessoa");
            float alturaPessoa2 = float.Parse(Console.ReadLine());

            float imcPessoa2 = (float) (pesoPessoa2 / Math.Pow(alturaPessoa2,2));//casting


 
            Console.WriteLine($"Pessoa 2 pesa {pesoPessoa2} e sua altura é {alturaPessoa2} e seu IMC é {imcPessoa2} ");
           
            #endregion


        }
    }
}
