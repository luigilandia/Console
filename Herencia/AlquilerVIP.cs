using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrol.Herencia
{
    class AlquilerVIP : Alquiler
    {
        public AlquilerVIP(int numero, double importe) : base(numero, importe)
        {
        }

        public override double ImporteFinal()
        {
            return base.ImporteFinal()+200;
        }
    }
}
