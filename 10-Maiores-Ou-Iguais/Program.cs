//10.Ler 02 números reais do teclado (A e B), 
//verificar e imprimir qual deles é o maior, 
//ou a mensagem "A = B" caso sejam iguais.

using System;

namespace _10_Maiores_Ou_Iguais
{
    class Program
    {
        static void Main(string[] args)
        {
            float Real1, Real2;

            Console.Write("Digite um número real: ");
            Real1 = float.Parse(Console.ReadLine());
           
            Console.Write("Digite outro número real: ");
            Real2 = float.Parse(Console.ReadLine());

            if (Real1 < Real2)
            {
                Console.WriteLine("O {0} é maior que {1}", Real2, Real1);
            }
            else if (Real1 > Real2)
            {
                Console.WriteLine("O {0} é maior que {1}", Real1, Real2);
            }
            else
            {
                Console.WriteLine("Os números são iguais");
            }
            
        }
    }
}
