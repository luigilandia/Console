using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrol
{
    class Rectangulo
    {
        private double _lado1;
        private double _lado2;

        public Rectangulo(double lado1, double lado2)
        {
            Lado1 = lado1;
            Lado2 = lado2;
        }

        private double Lado1 { get; set; }
        private double Lado2 { get; set; }

        public double Area()
        {
            return Lado1 * Lado2;
        }

        public double Perimetro()
        {
            return 2 * Lado1 + 2 * Lado2;
        }
    }
}
