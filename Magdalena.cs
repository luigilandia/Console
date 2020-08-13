using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrol
{
    class Magdalena
    {
        private string _color;
        private int _peso;
        private int _precio;

        public Magdalena(string color, int peso, int precio)
        {
            Color = color;
            Peso = peso;
            Precio = precio;
        }

        public string Color
        {
            get
            {
                return _color;
            }
            set
            {
                if (!value.Equals("Azul"))
                {
                    _color = value;
                }
            }
        }

        public int Peso
        {
            get
            {
                return _peso;
            }
            set
            {
                if(value<=4)
                {
                    _peso = value;
                }
            }
        }

        public int Precio
        {
            get
            {
                return _precio;
            }
            set
            {
                if (value <= 4)
                {
                    _precio = value;
                }
            }
        }
    }
}
