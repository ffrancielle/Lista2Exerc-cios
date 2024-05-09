using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a;
            int b;
            int c;

            Console.Write("Digite o 1º valor: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Digite o 2º valor: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Digite o 3º valor: ");
            c = int.Parse(Console.ReadLine());

            if (a == b)
                if (a == c)
                    Console.WriteLine("Iguais");
                else
                    if (a > c)
                    Console.WriteLine("1º/2º");
                else
                    Console.WriteLine("3º");
            else
                if (a == c)
                if (a > b)
                    Console.WriteLine("1º/3º");
                else
                    Console.WriteLine("2º");
            else
                   if (b == c)
                if (b > a)
                    Console.WriteLine("2º/3º");
                else
                    Console.WriteLine("1º");
            else
                      if (a > b)
                if (a > c)
                    Console.WriteLine("1º");
                else
                    Console.WriteLine("3º");
            else
                         if (b > c)
                Console.WriteLine("2º");
            else
                Console.WriteLine("3º");
        }
    }
}
