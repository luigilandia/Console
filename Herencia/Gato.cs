using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrol.Herencia
{
    class Gato : Animal
    {
        public Gato(string color, int peso) : base(color, peso)
        {
        }

        public string Cascabel { get; set; }

        public override void Vacunar()
        {
            Console.WriteLine("vacunamos al gato con 1 inyección");
            estaVacunado = true;
        }
    }
}
