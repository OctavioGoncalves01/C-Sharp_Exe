//8.   Fazer um algoritmo para ler 03 números reais do teclado 
//e verificar se o primeiro é maior que a soma dos outros dois.

using System;

namespace _08_Maior_Que
{
    class Program
    {
        static void Main(string[] args)
        {
            float Num1, Num2, Num3;

            Console.Clear();
            Console.WriteLine("Programa para saber se o primeiro número Real é maior que a soma dos outros dois");

            Console.WriteLine("Digite o promeiro número: ");
            Num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            Num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro número: ");
            Num3 = float.Parse(Console.ReadLine());

            if (Num1 < (Num2 + Num3))
            {
                Console.WriteLine("O Primeiro número é menor que a soma dos outros dois");
            }
            else if (Num1 > (Num2 + Num3))
            {
                Console.WriteLine("O Primeiro número é maior que a soma dos outros dois");
            }
            else
            {
                Console.WriteLine("A soma do segundo mais o terceiro é igual ao primeiro");
            }

        }
    }
}
