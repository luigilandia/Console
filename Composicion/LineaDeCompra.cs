using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrol.Composicion
{
    class LineaDeCompra
    {
        public LineaDeCompra(int numero, string concepto, double importe)
        {
            Numero = numero;
            Concepto = concepto;
            Importe = importe;
        }

        public int Numero { get; set; }
        public string Concepto { get; set; }
        public double Importe { get; set; }

        public double ImporteConIVA()
        {
            return Importe * 1.21;
        }

    }
}
