using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrol.Herencia
{
    class Empresa
    {
        public List<Alquiler> Alquileres { get; set; }

        public Empresa()
        {
            Alquileres = new List<Alquiler>();
        }

        public void AddAlquiler(Alquiler a)
        {
            this.Alquileres.Add(a);
        }

        public double CalcularSumaTotal()
        {
            double Total = 0;
            foreach (Alquiler al in Alquileres)
            {
                Total += al.ImporteFinal();
            }
            return Total;
        }

        public Alquiler DevuelveMasCaro()
        {
            Alquiler alMasCaro = Alquileres[0];
            foreach(Alquiler a in Alquileres)
            {
                if (alMasCaro.ImporteFinal() < a.ImporteFinal())
                {
                    alMasCaro = a;
                }
                
            }
            return alMasCaro;
        }

        public void RemoveAlquiler(Alquiler a)
        {
            this.Alquileres.Remove(a);
        }

        public int NumAlquileres()
        {
            return this.Alquileres.Count();
        }

        public bool ContieneAlquiler(Alquiler a)
        {
            return this.Alquileres.Contains(a);
        }
    }
}
