using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_del_ejercicio_de_concurso
{
    public abstract class Concurso
    {
        public string modalidad { get; set; }

        public void MostrarModalidad()
        {
            Console.WriteLine("Modalidad del concurso: {0}", modalidad);
        }

        public abstract void MostrarParticipante();
        public abstract void MostrarLaboratorio();

    }
}
