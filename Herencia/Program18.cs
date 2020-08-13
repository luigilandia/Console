using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrol.Herencia
{
    class Program18
    {
        static void Main(string[] args)
        {
            Empresa e = new Empresa();
            e.AddAlquiler(new Alquiler(2, 500));
            e.AddAlquiler(new AlquilerJoven(4, 800));
            e.AddAlquiler(new AlquilerVIP(2, 900));
            e.AddAlquiler(new Alquiler(2, 800));
            e.AddAlquiler(new Alquiler(2, 700));

            Console.WriteLine(e.CalcularSumaTotal());
            Alquiler elegido = e.DevuelveMasCaro();
            Console.WriteLine(elegido.Numero);
            Console.WriteLine(elegido.ImporteFinal());
            Console.WriteLine(e.ContieneAlquiler(new Alquiler(2, 700)));
            Console.ReadLine();
        }
    }
}
