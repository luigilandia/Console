using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrol.Herencia
{
    class Perro : Animal
    {
        public Perro(string color, int peso) : base(color, peso)
        {
        }
        public string Collar { get; set; }
        public override void Vacunar()
        {
            Console.WriteLine("El perro ya está vacunado");
            estaVacunado = true;
        }
    }
}
