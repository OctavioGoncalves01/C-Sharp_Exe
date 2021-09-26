// 13. Ler 4 números inteiros e calcular a soma dos que forem par

using System;

namespace _13_Somando_Par
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num1, Num2, Num3, Num4, Soma = 0;

            Console.WriteLine("O programa ira somar somente os números pares!");
            
            Console.Write("Digite o primeiro número: ");
            Num1 = int.Parse(Console.ReadLine());
            if (Num1 % 2 == 0)
            {
                Soma += Num1;
            }

            Console.Write("Digite o segundo número: ");
            Num2 = int.Parse(Console.ReadLine());
            if (Num2 % 2 == 0)
            {
                Soma += Num2;
            }

            Console.Write("Digite o terceiro número: ");
            Num3 = int.Parse(Console.ReadLine());
            if (Num3 % 2 == 0)
            {
                Soma += Num3;
            }

            Console.Write("Digite o quarto número: ");
            Num4 = int.Parse(Console.ReadLine());
            if (Num4 % 2 == 0)
            {
                Soma += Num4;
            }

            Console.WriteLine("A soma dos números pares digitados é: {0}", Soma);

        }
    }
}
