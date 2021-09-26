//7.Calcular a média final  (nota bimestre 1 + bimestre 2 +  bimestre3 dividido por 3 )
//dadas as  notas dos 4 bimestres e produzir uma saída com a média e a situação do aluno de
//acordo com o seguinte critério: média >=6, aprovado; média < 6, reprovado.a

using System;

namespace _07_Media_Final
{
    class Program
    {
        static void Main(string[] args)
        {
            double Nota1, Nota2, Nota3, Nota4, Media;

            Console.WriteLine("Digite a primeira nota: ");
            Nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota: ");
            Nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota: ");
            Nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quarta nota: ");
            Nota4 = double.Parse(Console.ReadLine());

            Media = (Nota1 + Nota2 + Nota3 + Nota4) / 4;

            if (Media < 4)
            {
                Console.WriteLine("Aluno Reprovado\nNota:\t" + Media);
            }
            else if (Media < 6.5)
            {
                Console.WriteLine("Aluno de REcuperação\nNota:\t" + Media);
            }
            else if (Media < 9)
            {
                Console.WriteLine("Aluno Aprovado\nNota:\t" + Media);
            }
            else
            {
                Console.WriteLine("Aluno Aprovado com louvor\nNota:\t" + Media);
            }
        }
    }
}
