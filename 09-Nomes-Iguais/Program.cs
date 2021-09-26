//9. Ler um nome do teclado e verificar se é igual ao seu nome. 
//Imprimir conforme o caso: "NOME CORRETO" ou "NOME INCORRETO".

using System;

namespace _09_Nomes_Iguais
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nome = "OCTAVIO", NomeDigitado;

            Console.Write("Digite um nome: ");

            NomeDigitado = Console.ReadLine().ToUpper();

            if (Nome == NomeDigitado)
            {
                Console.WriteLine("NOME CORRETO");
            }
            else
            {
                Console.WriteLine("NOME INCORRETO");
            }
        }
    }
}
