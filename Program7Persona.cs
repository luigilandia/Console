using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrol
{
    class Program7Persona
    {
        static void Main(string[] args)
        {
            Persona p = new Persona();
            p.Edad = 40;
            p.Nombre = "Luisa";
            p.Apellidos = "García";
            Console.WriteLine("Tiempo para jubilarse: "+p.TiempoParaJubilarse());
            Console.WriteLine(p);
            Console.ReadLine();
        }
    }
}
