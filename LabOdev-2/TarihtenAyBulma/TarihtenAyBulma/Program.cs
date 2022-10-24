// gg.aa.yyyy formatında girilen bir tarihten ay bulma

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarihtenAyBulma
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            string tarih;
            string[] tarihler;

            Console.Write("Tarihi Giriniz = ");
            tarih = Console.ReadLine();

            tarihler = tarih.Split('.');
            Console.WriteLine(int.Parse(tarihler[1]));
            Console.ReadLine();
        }
    }
}
