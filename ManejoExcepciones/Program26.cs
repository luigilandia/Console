using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrol.ManejoExcepciones
{
    class Program26
    {
        public static void Main(string[] args)
        {
            try
            {
                Persona p = new Persona("Juan", 15);
                Console.WriteLine(p);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.ReadLine();
        }
    }
}
