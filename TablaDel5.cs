using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrol
{
    class TablaDel5
    {
        static void Main(string[] args)
        {
            Mult(5);
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(Mult(i));
            }
            Console.ReadLine();
        }

        public static int Mult(int num)
        {
            return num * 5;
        }
    }
}
