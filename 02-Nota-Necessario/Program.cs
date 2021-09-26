//2.Calcular a nota necessária para passar por média no 4º bimestre. Dados: notas dos 3 bimestres

using System;

namespace _02_Nota_Necessario
{
    class Program
    {
        static void Main(string[] args)
        {
            float NotaB1, NotaB2, NotaB3, Media;

            Console.WriteLine("Informe as notas:");

            Console.WriteLine("1° Bimestre:");
            NotaB1 = float.Parse(Console.ReadLine());

            Console.WriteLine("2° Bimestre:");
            NotaB2 = float.Parse(Console.ReadLine());

            Console.WriteLine("3° Bimestre:");
            NotaB3 = float.Parse(Console.ReadLine());

            Media = (40 - (NotaB1 + NotaB2 + NotaB3)) /4 ;
        
            Console.WriteLine("Nota necessario:\t{0}", Media);
           
        }
    }
}
