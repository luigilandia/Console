using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrol
{
    class Program6Magdalena
    {
        static void Main(string[] args)
        {
            Magdalena m = new Magdalena("Azul", 3,5);
            Console.WriteLine(m.Color);
            Console.WriteLine(m.Peso);
            Console.WriteLine(m.Precio);
            Console.ReadLine();
        }
    }
}
