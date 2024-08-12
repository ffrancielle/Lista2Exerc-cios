using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double notaP1;
            double notaP2Necessaria;
            double mediaAprovacao = 5.0;

            Console.Write("Digite o valor da nota P1: ");
            notaP1 = Convert.ToDouble(Console.ReadLine());

            notaP2Necessaria = (mediaAprovacao * 3 - notaP1) / 2;

            Console.WriteLine("Para ser aprovado, o aluno precisa tirar pelo menos {0} na segunda avaliação (P2).", notaP2Necessaria);
        }
    }
}
