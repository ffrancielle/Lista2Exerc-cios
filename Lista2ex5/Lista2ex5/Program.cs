using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double baseRetangulo;
            double alturaRetangulo;
            double area;

            Console.Write("Digite o valor da base do retângulo: ");
            baseRetangulo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor da altura do retângulo: ");
            alturaRetangulo = Convert.ToDouble(Console.ReadLine());


            area = baseRetangulo * alturaRetangulo;
            Console.WriteLine("A área do retângulo é: {0}", area);

            if (area > 100)
            {
                Console.WriteLine("Terreno grande");
            }
            else
            {
                Console.WriteLine("Terreno pequeno");

            }

            }
    }
}
