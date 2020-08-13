using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrol
{
	class Nota
	{
		public Nota(double valor)
		{
			Valor = valor;
		}

		public double Valor { get; set; }

		public string Tipo()
		{
            if (Valor > 0 && Valor < 3)
            {

                return "muy deficiente";
            }
            else if (Valor >= 3 && Valor < 5)
            {

                return "insuficiente";
            }
            else if (Valor >= 5 && Valor < 8)
            {

                return "notable";
            }
            else
            {
                return "sobresaliente";
            }
        }

        public Nota EsMayor(Nota otraNota)
        {
            if (otraNota.Valor > Valor)
            {
                return otraNota;
            }
            else
            {
                return this;
            }
        }

        public static Nota ElegirMayor(Nota nota1, Nota nota2)
        {
            // this hace referenia 
            // al objeto actual

            if (nota1.Valor > nota2.Valor)
            {
                return nota1;
            }
            else
            {
                return nota2;
            }
        }
    }
}
