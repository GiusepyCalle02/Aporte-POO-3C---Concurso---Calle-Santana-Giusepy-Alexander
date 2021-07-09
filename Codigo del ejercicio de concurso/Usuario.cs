using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_del_ejercicio_de_concurso
{
    public class Usuario : Laboratorio
    {
        //INFORMACION DEL USUARIO PARA EL CONCURSO
        public string nombre { get; set; }
        public int numcomputadora { get; set; }
        public string softwarerequerido { get; set; }


        public override void MostrarParticipante()
        {
            Console.WriteLine("Nombre del participante: {0}; Número de computadora: {1}; Software Requerido: {2}",nombre, numcomputadora, softwarerequerido);
        }
 
    }
}
