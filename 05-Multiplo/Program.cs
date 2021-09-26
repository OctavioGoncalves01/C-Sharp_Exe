//5.Ler dois números inteiros, X e Y, e apresentar mensagem informando se o X é múltiplo de Y.

using System;

namespace _05_Multiplo
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, Y;

            Console.WriteLine("Digite o primeiro valor: ");
            X = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            Y = int.Parse(Console.ReadLine());

            if (X % Y == 0)
            {
                Console.WriteLine("{0} é multiplo de {1}", X, Y);
            }
            else
            {
                Console.WriteLine("{0} não é multiplo de {1}", X, Y);
            }
        }
    }
}
