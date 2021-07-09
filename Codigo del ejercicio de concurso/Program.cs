using System;
using System.Collections.Generic;
namespace Codigo_del_ejercicio_de_concurso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Participantes del concurso: ");
            Usuario usuario1 = new Usuario();
            usuario1.nombre = "Giusepy Calle";
            usuario1.modalidad = "Lógica Básica";
            usuario1.numerodelaboratorio = 1;
            usuario1.numcomputadora = 2;
            usuario1.softwareinclud = "Visual Studio, Office, Dev-C++";
            usuario1.softwarerequerido = "Visual Studio";

            Usuario usuario2 = new Usuario();
            usuario2.nombre = "José Aranea";
            usuario2.modalidad = "Lógica Avanzada";
            usuario2.numerodelaboratorio = 2;
            usuario2.numcomputadora = 1;
            usuario2.softwareinclud = "PostgreSQL, Visio, Excel";
            usuario2.softwarerequerido = "PostgreSQL";

            Usuario usuario3 = new Usuario();
            usuario3.nombre = "Ariana Loor";
            usuario3.modalidad = "Empresarial";
            usuario3.numerodelaboratorio = 3;
            usuario3.numcomputadora = 5;
            usuario3.softwareinclud = "SQL Server, Adobe, NeatBeans";
            usuario3.softwarerequerido = "SQL Server";

            Usuario usuario4 = new Usuario();
            usuario4.nombre = "Peter Quimis";
            usuario4.modalidad = "Retos";
            usuario4.numerodelaboratorio = 4;
            usuario4.numcomputadora = 10;
            usuario4.softwareinclud = "Visual Studio, PostgreSQL, SQL Server";
            usuario4.softwarerequerido = "Visual Studio";

            List<Concurso> Lista = new List<Concurso>(); 
            Lista.Add(usuario1);
            Lista.Add(usuario2);
            Lista.Add(usuario3);
            Lista.Add(usuario4);

            foreach (Concurso concurso in Lista) 
            { 
                concurso.MostrarParticipante();
                concurso.MostrarModalidad();
                concurso.MostrarLaboratorio();   
                Console.WriteLine(); 
            }
        }
    }
}
