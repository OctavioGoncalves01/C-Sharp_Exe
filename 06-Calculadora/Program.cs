//6.Fazer um algoritmo para ler dois valores reais do teclado, calcular e imprimir na tela:
//a) A soma destes valores   b) O produto deles    c) O quociente entre eles.

using System;

namespace _06_Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            double X, Y, Soma, Quociente, Resto;

            Console.WriteLine("Use números Reais!!\n");
            
            Console.WriteLine("Digite o primeiro valor: ");
            X = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");
            Y = double.Parse(Console.ReadLine());
            
            while (Y == 0)
            {
                Console.WriteLine("Para melhor funcionamento do programa use um número diferente de 0 (zero)");
                Console.WriteLine("Digite o segundo valor:");
                Y = double.Parse(Console.ReadLine());
            }

            Soma = X + Y;
            Quociente = X / Y;
            Resto = X % Y;

            Console.WriteLine($"Soma: {X} + {Y} = {Soma}");
            Console.WriteLine($"Quociente: {X} / {Y} = {Quociente}");
            Console.WriteLine($"Resto: {X} % {Y} = {Resto}");

            Console.WriteLine("Aperte qualquer tecla...");
            Console.ReadKey();

        }
    }
}
