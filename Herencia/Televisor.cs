using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrol.Herencia
{
    class Televisor:Electrodomestico
    {
        public int Pulgadas { get; set; }

        public override void Encender()
        {
            base.Encender();
        }

        public override void Apagar()
        {
            Console.WriteLine("El televisor se apaga");
        }
    }
}
