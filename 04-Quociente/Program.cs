//4.Ler dois números inteiros, X e Y, e imprimir o quociente e o resto da divisão inteira entre eles.

using System;

namespace _04_Quociente
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, Y;
            int Resto = 0, Quociente = 0;

            Console.WriteLine("Digite um número inteiro");
            X = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro número inteiro");
            Y = int.Parse(Console.ReadLine());

            while (Y == 0)
            {
                Console.WriteLine("Valor invalido");
                Y = int.Parse(Console.ReadLine());
            }

            Resto = X % Y;
            Quociente = X / Y;

            Console.WriteLine("O quociente é {0}, e o resto {1}", Quociente, Resto);

        }
    }
}
