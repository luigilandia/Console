using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrol
{
    class Program10
    {
        static void Main(string[] args)
        {
            List<Nota> misNotas = new List<Nota>();
            misNotas.Add(new Nota(5));
            misNotas.Add(new Nota(7));
            misNotas.Add(new Nota(2));
            misNotas.Add(new Nota(8));
            misNotas.Add(new Nota(3));

            Nota notaMayor = new Nota(0);
            
            foreach(Nota n in misNotas)
            {
                notaMayor = n.EsMayor(notaMayor);
            }

            Console.WriteLine(notaMayor.Valor);
            Console.ReadLine();
        }
    }
}
