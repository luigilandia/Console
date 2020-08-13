using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrol.Herencia
{
    class Electrodomestico
    {
        public int NumeroSerio { get; set; }

        public virtual void Encender()
        {
            Console.WriteLine("El electrodoméstico se enciende");
        }

        public virtual void Apagar()
        {
            Console.WriteLine("El electrodoméstico se apaga");
        }
    }
}
