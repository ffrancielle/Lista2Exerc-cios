using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a;
            int b;

            Console.Write("Digite o 1° valor: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Digite o 2° valor: ");
            b = int.Parse(Console.ReadLine());

            if (a == b)

                Console.WriteLine("Os Valores são iguais");

            else

                if (a > b)


                Console.WriteLine("O primeiro valor é maior");

            else

                Console.WriteLine("O segundo valor é maior");
        }
    }
}
