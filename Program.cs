using System;
using System.Collections.Generic;
using CorEscuela.Entidades;
using CorEscuela.Util;
using static System.Console;

namespace CorEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new EscuelaEngine();
            engine.Inicializar();
            imprimirCursos(engine.Escuela);
        }

        private static void imprimirCursos(Escuela escuela)
        {
            Printer.WriteTitle("Cursos de la Escuela");

            foreach (var curso in escuela.Cursos)
            {

                foreach (var alumno in curso.Alumnos)
                {

                    foreach (var evaluacion in alumno.Evaluaciones)
                    {
                        WriteLine($"{curso.Nombre} {alumno.Nombre} {evaluacion.Nombre} {evaluacion.Nota}");
                    }

                }

            }
        }
    }
}
