using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrol.Composicion
{
    class Program16
    {
        static void Main(string[] args)
        {
            Ordenador or = new Ordenador(new CPU(), new Monitor(15));
            Portatil p = new Portatil(new CPU());
            //or.Encender();
            //or.Apagar();
            p.Encender();
            Console.ReadLine();
        }
    }
}
