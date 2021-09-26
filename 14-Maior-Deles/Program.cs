//14.Ler três valores e determinar o maior dentre eles.

using System;
using System.Linq;

namespace _14_Maior_Deles
{
    class Program
    {
        static void Main(string[] args)
        {
            int Numero, Maior = 0;

            for (int I = 0; I < 3; I++ )
            {
                Console.WriteLine("Escreva um numero inteiro: ");
                Numero = int.Parse(Console.ReadLine());

                if (Numero > Maior)
                {
                    Maior = Numero;
                }
            }

            Console.WriteLine("O maior numero digitado foi: " + Maior);
        }
    }
}
