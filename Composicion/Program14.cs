using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrol.Composicion
{
    class Program14
    {
        static void Main(string[] args)
        {
            Compra c = new Compra(1);
            c.AddLinea(new LineaDeCompra(1, "Ordenador", 400));
            c.AddLinea(new LineaDeCompra(2, "Tablet", 300));

            Console.WriteLine(c.Importe);
            Console.WriteLine(c.ImporteConIva());
            Console.ReadLine();
        }
    }
}
