using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrol
{
    class Program8Factura
    {
        static void Main(string[] args)
        {
            Factura f = new Factura(2, "ordenador", 500);
            Console.WriteLine(f.CalcularIVA(12));
            Console.WriteLine(f.CalcularIva());
            Console.ReadLine();
        }
    }
}
