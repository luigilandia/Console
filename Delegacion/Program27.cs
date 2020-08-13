using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrol.Delegacion
{
    class Program27
    {
        delegate int Operacion(int a, int b);
        public static void Main(string[] args)
        {
            Operacion o = new Operacion(Sumar);
            int Resultado = o(2, 2);
            Console.WriteLine(Resultado);
            Console.ReadLine();
        }

        public static int Sumar(int a, int b)
        {
            return a + b;
        }
    }
}
