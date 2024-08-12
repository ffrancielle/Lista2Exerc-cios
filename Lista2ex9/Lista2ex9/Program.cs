using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double peso;
            double altura;
            double relacaoPesoAltura;
            string sexo;

            Console.Write("Digite o peso da pessoa (em kg): ");
            peso = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a altura da pessoa (em metros): ");
            altura = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o sexo da pessoa (M para masculino, F para feminino): ");
            sexo = Console.ReadLine();

            relacaoPesoAltura = peso / (altura * altura);

            Console.WriteLine("A relação peso/altura² (IMC) é: {0}", relacaoPesoAltura);

            if (sexo == "M" || sexo == "m")
            {
                if (relacaoPesoAltura < 20)
                {
                    Console.WriteLine("Abaixo do peso");
                }
                else if (relacaoPesoAltura >= 20 && relacaoPesoAltura < 25)
                {
                    Console.WriteLine("Peso ideal");
                }
                else
                {
                    Console.WriteLine("Acima do peso");
                }
            }
            else if (sexo == "F" || sexo == "f")
            {
                if (relacaoPesoAltura < 19)
                {
                    Console.WriteLine("Abaixo do peso");
                }
                else if (relacaoPesoAltura >= 19 && relacaoPesoAltura < 24)
                {
                    Console.WriteLine("Peso ideal");
                }
                else
                {
                    Console.WriteLine("Acima do peso");
                }
            }
            else
            {
                Console.WriteLine("Sexo inválido. Por favor, digite M para masculino ou F para feminino.");
            }
        }
    }
}
