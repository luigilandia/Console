using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrol
{
    class Persona
    {
        public Persona(string nombre, string apellidos, int edad)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            Edad = edad;
        }

        public Persona()
        {

        }

        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int Edad { get; set; }

        public int TiempoParaJubilarse()
        {
            return 70 - Edad;
        }

        public override string ToString()
        {
            return "La persona se llama " + Nombre + " " + Apellidos + " y tiene " + Edad + " años";
        }

    }
}
