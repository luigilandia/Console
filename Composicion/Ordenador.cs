using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrol.Composicion
{
    class Ordenador
    {
        public Ordenador(CPU cpu, Monitor monitor)
        {
            this.cpu = cpu;
            this.monitor = monitor;
        }

        public CPU cpu { get; set; }
        public Monitor monitor { get; set; }

        public virtual void Encender()
        {
            cpu.Encender();
            monitor.Encender();
        }

        public virtual void Apagar()
        {
            cpu.Apagar();
            monitor.Apagar();
        }
    }
}
