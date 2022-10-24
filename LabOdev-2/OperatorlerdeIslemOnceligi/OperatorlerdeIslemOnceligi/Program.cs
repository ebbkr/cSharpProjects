using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorlerdeIslemOnceligi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(48 / 6 / 4); // Sonuç:2
            Console.WriteLine(24 / 3 * 2); // Önce bölme daha sonra çarpma işlemi yapılır. Sonuç:16
            Console.WriteLine((2 * 2) + 5 - 1 + 4); //Önce üs alma işlemi yapılır. Sonuç:12
            Console.WriteLine((7 + 4) * 2 - 1 + 8 / 2); //Sırasıyla parantez içindeki işlem, çarpma ve bölme yapılır. Sonuç:25
            Console.WriteLine((5 - 1) * 2 - 1 + (7 * 7) / 2); // Sırasıyla üs alma, parantez içi, çarpma ve bölme işlemleri yapılır. Sonuç:31,5
            Console.ReadLine();
        }
    }
}
