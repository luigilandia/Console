using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Semicrol.ManejoExcepciones
{
    class Persona
    {
        public string Nombre { get; set; }
        public int _edad;

        public int Edad
        {
            get
            {
                return _edad;
            }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new Exception("Esa edad es imposible");
                }
                else
                {
                    _edad = value;
                }
            }
        }

        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public override string ToString()
        {
            return "Se llama " + Nombre + " y tiene " + Edad;
        }
    }
}
