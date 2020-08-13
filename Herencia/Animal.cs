using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrol.Herencia
{
    abstract class Animal
    {
        public Animal(string color, int peso)
        {
            Color = color;
            Peso = peso;
        }

        public string Color { get; set; }
        public int Peso { get; set; }
        public bool estaVacunado { get; set; }

        public abstract void Vacunar();

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
