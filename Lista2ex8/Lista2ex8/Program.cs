using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double ladoA;
            double ladoB;
            double ladoC;

            Console.Write("Digite o valor do primeiro lado: ");
            ladoA = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor do segundo lado: ");
            ladoB = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor do terceiro lado: ");
            ladoC = Convert.ToDouble(Console.ReadLine());

            if ((ladoA * ladoA == ladoB * ladoB + ladoC * ladoC) ||
                (ladoB * ladoB == ladoA * ladoA + ladoC * ladoC) ||
                (ladoC * ladoC == ladoA * ladoA + ladoB * ladoB))
            {
                Console.WriteLine("Os valores digitados formam um triângulo retângulo");
            }
            else
            {
                Console.WriteLine("Os valores digitados não formam um triângulo retângulo");
            }
        }
    }
}
