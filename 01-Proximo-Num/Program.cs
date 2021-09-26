//1.   Leia um número e exiba o seu sucessor.

using System;

namespace _01_Proximo_Num
{
    class Program
    {
        static void Main(string[] args)
        {
            int Numero;
            
            Console.WriteLine("Informe um número para mostrar o seu sucesso: ");

            Numero = int.Parse(Console.ReadLine());

            Console.WriteLine("O sucessor de {0} é {1}", Numero, Numero+1);
        }
    }
}
