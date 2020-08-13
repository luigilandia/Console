using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrol.Composicion
{
    class Portatil : Ordenador
    {
        public Portatil(CPU cpu) : base(cpu, new Monitor(15))
        {
        }

        public override void Encender()
        {
            base.Encender();
            Console.WriteLine("El portátil se enciende");
        }
    }
}
