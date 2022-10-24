using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantiksalIfadeler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 20;
            int y = 13;
            int z = 42;

            if (23 == 55 && 76 > 45 && 5 < 12) // 3 koşulun hepsi sağlanmadığı için yanlıştır.
            {
                Console.WriteLine("1. İfade Doğru!");
            }

            if (23 >= 23 && 45 != 18) // 2 koşul da sağlandığı için doğrudur.
            {
                Console.WriteLine("2. İfade Doğru!");
            }
            if (x > y && z == y && z < x) //Yalnızca 1 koşul doğru olduğu için yanlıştır.
            {
                Console.WriteLine("3. İfade Doğru!"); 
            }
            if (z > x && y < x) // 2 koşul da sağlandığı için doğrudur. 
            {
                Console.WriteLine("4. İfade Doğru!");
            }
            if (x != z || y <= z) // En az 1 koşul doğru olduğu için doğrudur.
            {
                Console.WriteLine("5. İfade Doğru!");
            }

            Console.ReadLine();

        }
    }
}
