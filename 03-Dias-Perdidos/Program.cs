//3. Calcular a quantidade de dinheiro gasta por um fumante. Dados: 
//o número de anos que ele fuma, o nº de cigarros fumados por dia e o preço de uma carteira.

using System;

namespace _03_Dias_Perdidos
{
    class Program
    {
        static void Main(string[] args)
        {
            double Numeros_Cigarros, Anos, Soma = 0, Preco;

            Console.WriteLine("Quantos cigarros você fuma por dia: ");
            Numeros_Cigarros = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantos anos você fuma: ");
            Anos = double.Parse(Console.ReadLine());

            Inicio:
            Console.WriteLine("Digite o preço médio do maço de cigarro: ");
            Preco = double.Parse(Console.ReadLine());

            if (Preco <= 0)
            {
                Console.WriteLine("Valor do maço inferio a 0 reais");
                goto Inicio;
            }
            else
            {
                Soma = (365 * Anos * Numeros_Cigarros / 20) * Preco;
                Console.WriteLine("Você já gastou R${0} com cigarros", Soma);
            }

            Console.WriteLine("Aperte uma tecla para fechar");
            Console.ReadKey();
            
        }
    }
}
