using System;

namespace DiferencaDosProdutos_CSharp_04
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int A, B, C, D, DIFERENCA;

            Console.WriteLine("Digite os valores de A, B, C e D:");
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());

            DIFERENCA = A * B - C * D;

            Console.WriteLine("A diferença dos produtos é: " + DIFERENCA);
        }
    }
}
