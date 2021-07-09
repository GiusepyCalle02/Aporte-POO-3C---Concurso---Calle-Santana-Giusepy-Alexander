using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_del_ejercicio_de_concurso
{
    public abstract class Laboratorio: Concurso
    {
        public int numerodelaboratorio { get; set; }
        public string softwareinclud { get; set; }


        public override void MostrarLaboratorio()
        {
            Console.WriteLine("Numero de laboratorio: {0}; Software incluido: {1}", numerodelaboratorio, softwareinclud);
        }
    }
}
