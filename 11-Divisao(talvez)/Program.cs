//11.   Ler 02 números inteiros do teclado. 
//Se o segundo for diferente de zero, calcular e imprimir o quociente do primeiro pelo segundo. 
//Caso contrário, imprimir a mensagem: "DIVISÃO POR ZERO".

using System;

namespace _11_Divisao_talvez_
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num1, Num2, Quociente, Resto;

            Console.WriteLine("Digite o primeiro número: ");
            Num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            Num2 = int.Parse(Console.ReadLine());

            if (Num2 == 0)
            {
                Console.WriteLine("DIVISÃO POR ZERO");
            }
            else
            {
                Quociente = Num1 / Num2;
                Resto = Num1 % Num2;

                Console.WriteLine("O quociente é: " + Quociente + "\nE o resto: " + Resto);
            }
        }
    }
}
