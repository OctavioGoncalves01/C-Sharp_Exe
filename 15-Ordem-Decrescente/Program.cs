//15.Ler três valores e colocá-los em ordem decrescente.

using System;

namespace _15_Ordem_Decrescente
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("Digite a primeiro número.");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segundo número.");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a terceiro número.");
            c = int.Parse(Console.ReadLine());

            if (a > b && a > c && b > c)
                {
                Console.WriteLine(a +", "+ b +", "+ c);
                }
            
            if (a > b && a > c && c > b)
                {
                Console.WriteLine(a +", "+ c +", "+ b);
                }
            
            if (b > a && b > c && a > c)
                {
                Console.WriteLine(b +", "+ a +", "+ c);
                }
            
            if (b > a && b > c && c > a)
                {
                Console.WriteLine(b +", "+ c +", "+ a);
                }
            
            if (c > a && c > b && a > b)
                {
                Console.WriteLine(c +", "+ a +", "+ b);
                }
            
            if (c > a && c > b && b > a)
                {
                Console.WriteLine(c +", "+ b +", " +a);
                }
            
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
