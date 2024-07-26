using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double baseRetangulo;
            double alturaRetangulo;
            double area;

            Console.Write("Digite a base do retângulo: ");
            baseRetangulo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a altura do retângulo: ");
            alturaRetangulo = Convert.ToDouble(Console.ReadLine());

            area = baseRetangulo * alturaRetangulo;

            Console.Write("A área do retângulo é: ");
            Console.WriteLine(area);

            if (area > 100)
            {
                Console.WriteLine("Terreno grande");
            }
        }
    }
}
