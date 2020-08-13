using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrol.ManejoExcepciones
{
    class Program25
    {
        public static void Main(string[] args)
        {
            string ruta = @"C:\users\prueba.txt";
            try
            {
                //La claúsula using cierra lo que metamos dentro de ella
                using (StreamReader sr = File.OpenText(ruta))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
            } catch (Exception e)
            {
                Console.WriteLine("Ha ocurrido una excepción");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);

            }
            /*finally
            {
                Console.WriteLine("Todo cerrado");
            }*/
            Console.ReadLine();
        }
    }
}
