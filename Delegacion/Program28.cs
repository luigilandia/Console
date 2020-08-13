using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrol.Delegacion
{
    class Program28
    {
        public static void Main(string[] args)
        {
            Func<int, int, int> miFuncion = (a, b) => a * b;
            int Res=miFuncion(2, 3);
            Console.WriteLine(Res);
            OperarPorPantalla(2, 3, Sumar);
            Console.ReadLine();
        }
        public static int Sumar(int a, int b)
        {
            return a + b;
        }
        public static int Restar(int a, int b)
        {
            return a - b;
        }

        public static void OperarPorPantalla(int a, int b, Func<int, int, int> tipoOperación)
        {
            Console.WriteLine("*********");
            Console.WriteLine(tipoOperación(a, b));
            Console.WriteLine("************");
        }
    }
}
