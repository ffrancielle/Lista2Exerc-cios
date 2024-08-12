using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double ladoA;
            double ladoB;
            double ladoC;

            Console.Write("Digite o valor do primeiro lado do triângulo: ");
            ladoA = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor do segundo lado do triângulo: ");
            ladoB = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor do terceiro lado do triângulo: ");
            ladoC = Convert.ToDouble(Console.ReadLine());

            if ((ladoA + ladoB > ladoC) && (ladoA + ladoC > ladoB) && (ladoB + ladoC > ladoA))
            {
                if (ladoA == ladoB && ladoB == ladoC)
                {
                    Console.WriteLine("Triângulo equilátero");
                }
                else if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
                {
                    Console.WriteLine("Triângulo isósceles");
                }
                else
                {
                    Console.WriteLine("Triângulo escaleno");
                }
            }
            else
            {
                Console.WriteLine("Os valores digitados não formam um triângulo");
            }
        }
    }
}
