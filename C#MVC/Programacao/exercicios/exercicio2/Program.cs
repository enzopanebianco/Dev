using System;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region altura

            Console.WriteLine("Informe a altura");
            float altura = float.Parse (Console.ReadLine());


            #endregion

            #region base

           Console.WriteLine("Informe a base ");
           float bases = float.Parse (Console.ReadLine());



            #endregion

            #region area
            
            float area= (float) (altura * bases) ;

            Console.WriteLine($" Sua area é  {area}" );

            #endregion

        }
    }
}
