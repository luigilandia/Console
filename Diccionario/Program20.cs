using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrol.Diccionario
{
    class Program20
    {
        static void Main (string[] args)
        {
            Dictionary<string, Persona> diccionario = new Dictionary<string, Persona>();
            Persona p1 = new Persona();
            p1.Nombre = "Luisa";
            p1.Apellidos = "García";
            p1.Edad = 30;
            diccionario.Add("Luisa", p1);

            foreach (Persona p in diccionario.Values)
            {
                Console.WriteLine(p);
            }
            foreach(String nombre in diccionario.Keys)
            {
                Console.WriteLine(nombre);
            }

            Console.ReadLine();
        }
    }
}
