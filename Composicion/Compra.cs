using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Semicrol.Composicion
{
    class Compra
    {
        public Compra(int id)
        {
            Id = id;
            lineas = new List<LineaDeCompra>();
        }

        public int Id { get; set; }
        public List<LineaDeCompra> lineas { get; set; }

        public void AddLinea(LineaDeCompra linea)
        {
            this.lineas.Add(linea);
        }

        public double Importe
        {
            get
            {
                double Total = 0;
                foreach(LineaDeCompra l in lineas)
                {
                    Total += l.Importe;
                }
                return Total;
            }
        }

        public double ImporteConIva()
        {
            double Total = 0;
            foreach(LineaDeCompra l in lineas)
            {
                Total += l.ImporteConIVA();
            }
            return Total;
        }
    }
}
