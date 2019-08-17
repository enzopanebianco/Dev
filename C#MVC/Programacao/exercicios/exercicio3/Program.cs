using System;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1
                
            
            Console.WriteLine("produto1:");
            float produto1 = float.Parse(Console.ReadLine());

            #endregion

            #region 2
                
            
            Console.WriteLine("produto2:");
            float produto2 = float.Parse(Console.ReadLine());

            #endregion

            #region 3
                
            
            Console.WriteLine("produto3:");
            float produto3 = float.Parse(Console.ReadLine());

            #endregion

            #region 4
                
            
            Console.WriteLine("produto4:");
            float produto4 = float.Parse(Console.ReadLine());

            #endregion

            #region 5
                
            
            Console.WriteLine("produto5:");
            float produto5 = float.Parse(Console.ReadLine());

            #endregion

            #region media

            float media = (produto1 + produto2 + produto3 + produto4 + produto5  ) / 5;
            
            Console.WriteLine($"A Média da sua compra é : {media}");

            #endregion

        }
    }
}
