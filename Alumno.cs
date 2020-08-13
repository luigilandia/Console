using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrol
{
    class Alumno
    {
        public string Nombre { get; set; }
        private List<Nota> _notas = new List<Nota>();

        public Alumno(string nombre)
        {
            Nombre = nombre;
        }

        public List<Nota> Notas
        {
            get
            {
                return _notas;
            }
            set
            {
                _notas = value;
            }
        }

        public void AddNota(Nota nota)
        {
            this.Notas.Add(nota);
        }

        public Nota NotaMayor()
        {
            Nota notaMayor = Notas[0];
            foreach(Nota unaNota in Notas)
            {
                notaMayor = unaNota.EsMayor(notaMayor);
            }
            return notaMayor;
        }
    }
}
