using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrol.Herencia
{
    class Alquiler
    {
        public Alquiler(int numero, double importe)
        {
            Numero = numero;
            Importe = importe;
        }

        public int Numero { get; set; }
        public double Importe { get; set; }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public virtual double ImporteFinal()
        {
            return Importe * 1.21;
        }
    }
}
