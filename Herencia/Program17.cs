using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrol.Herencia
{
    class Program17
    {
        static void Main (string[] args)
        {
            Animal g1 = new Gato("blanco", 12);
            Animal p1 = new Perro("blanco", 12);
            //VacunarAnimal(p1);
            

            Animal a1 = FactoriaAnimales.GetAnimal("Gato", 30, "blanco");
            
            Gato miGato = (Gato)a1;
            VacunarAnimal(a1);
            Console.ReadLine();

        }

        public static void VacunarAnimal(Animal a)
        {
            a.Vacunar();
            Console.WriteLine(a.estaVacunado);
        }
    }
}
