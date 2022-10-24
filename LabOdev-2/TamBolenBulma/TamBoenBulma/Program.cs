// Girilen 2 sayinin bir birine tam bolunup bolunmedıgını bulan program

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamBoenBulma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int x;
            Console.WriteLine("1. sayiyi giriniz:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2. sayiyi giriniz:");
            int y;
            y = Convert.ToInt32(Console.ReadLine());

            if(x % y == 0)
            {
                Console.WriteLine("Sayilar biribirine tam bölünmektedir!");
            } 
            else
            {
                Console.WriteLine("Sayilar birbirine tam bölünemez!");
            }

            Console.ReadLine();
        }
    }
}
