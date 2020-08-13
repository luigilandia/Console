using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrol
{
    class Factura
    {
        public Factura(int numero, string concepto, double importe)
        {
            Numero = numero;
            Concepto = concepto;
            Importe = importe;
        }

        public int Numero { get; set;}
        public string Concepto { get; set; }
        public double Importe { get; set; }

        public double CalcularIva()
        {
            return Importe * 1.21;
        }

        public double CalcularIVA(int porcentaje)
        {
            return Importe + (Importe * porcentaje / 100);
        }
    }
}
