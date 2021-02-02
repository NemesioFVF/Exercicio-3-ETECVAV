using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor de 'A': ");
            Double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o valor de 'B': ");
            Double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o valor de 'C': ");
            Double c = Convert.ToDouble(Console.ReadLine());
            Double A = Math.Pow(a, 2);
            Double r = A*5-c/(b-a%4);
            Console.WriteLine("O resultado é: " + r);
            Console.ReadKey();
        }
    }
}
