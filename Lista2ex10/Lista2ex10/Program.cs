using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double notaP1;
            double notaP2;
            double media;

            Console.Write("Digite o valor da nota P1: ");
            notaP1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor da nota P2: ");
            notaP2 = Convert.ToDouble(Console.ReadLine());

            media = (notaP1 + 2 * notaP2) / 3;

            Console.WriteLine("A média do aluno é: {0}", media);

            if (media >= 5)
            {
                Console.WriteLine("Situação do aluno: Aprovado");
            }
            else
            {
                Console.WriteLine("Situação do aluno: Reprovado");
            }
        }
    }
}
