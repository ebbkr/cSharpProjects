// Ikinci dereceden denklemin koklerini bulan program

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenklemKokleriniBulma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            double delta, x1, x2;
            
            Console.Write("a değerini giriniz:");
            a = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("b değerini giriniz:");
            b = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("c değerini giriniz:");
            c = Convert.ToInt32(Console.ReadLine());
 
            delta = b * b - 4 * a * c;
            if (delta == 0)
            {
                Console.WriteLine("Kökler birbirine esi!t");
            }
            else if (delta < 0)
            {
                Console.WriteLine("Kökler reel degil!");
            }
            else
            {
                x1 = ((-1) * b - Math.Sqrt(delta)) / 2 * a;
                x2 = ((-1) * b + Math.Sqrt(delta)) / 2 * a;
                Console.WriteLine("x1={0}, x2={1}", x1, x2);
            }
            Console.ReadLine();

            }
    }
}
