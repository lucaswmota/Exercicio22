using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio22
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Informe a metragem da frente do imovel: ");
            double frente = double.Parse(Console.ReadLine());

            Console.Write("Informe a metragem do lado do terreno: ");
            double lado = double.Parse(Console.ReadLine());

            Console.Write("Informe o % de acréscimo: ");
            double acrescimo = double.Parse(Console.ReadLine());

            double metragem = ((frente*lado) / 100) * acrescimo + (frente*lado);
            
            Console.Write("A Metragem a ser comprada é: " + metragem.ToString("F3"));

            Console.ReadKey();
        }
    }
}
