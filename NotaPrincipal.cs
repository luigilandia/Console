using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrol
{
	class NotaPrincipal
	{
		static void Main(string[] args)
		{
			Nota nResultado = Nota.ElegirMayor(new Nota(7), new Nota(3));
			Nota n1 = new Nota(8);
			//Nota nResultado2 = n1.ElegirMayor(new Nota(5));
			
			Console.WriteLine(nResultado.Valor);
			//Console.WriteLine(nResultado2.Valor);

			Console.ReadLine();
		}
	}
}
