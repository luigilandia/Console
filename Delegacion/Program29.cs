using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrol.Delegacion
{
    class Program29
    {
        public static void Main(string[] args)
        {
            List<Persona> lista = new List<Persona>();
            lista.Add(new Persona("Juan", 20));
            lista.Add(new Persona("Mario", 10));
            lista.Add(new Persona("Lucas", 60));
            lista.Add(new Persona("Marta", 40));
            lista.Add(new Persona("Luisa", 30));

            IEnumerable<Persona> Resultado = lista.Where((personita) => personita.Edad >= 40);

            foreach (Persona p in Resultado)
            {
                Console.WriteLine(p.Nombre);
            }
            Console.ReadLine();
        }
    }
}
