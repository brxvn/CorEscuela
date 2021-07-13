using System;
using System.Collections.Generic;
using CorEscuela.Entidades;
using static System.Console;

namespace CorEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Platzi Academy", 2012, TiposEscuela.Primaria, ciudad: "Bogotá");

            escuela.Cursos = new List<Cursos>(){
                new Cursos() {Nombre = "101", Jornada = TiposJornada.Mañana},
                new Cursos() {Nombre = "201", Jornada = TiposJornada.Mañana},
                new Cursos() {Nombre = "301", Jornada = TiposJornada.Mañana}
            };

            escuela.Cursos.Add(new Cursos { Nombre = "102", Jornada = TiposJornada.Tarde });
            escuela.Cursos.Add(new Cursos { Nombre = "202", Jornada = TiposJornada.Tarde });

            var otraColection = new List<Cursos>(){
                new Cursos() {Nombre = "401", Jornada = TiposJornada.Mañana},
                new Cursos() {Nombre = "501", Jornada = TiposJornada.Mañana},
                new Cursos() {Nombre = "501", Jornada = TiposJornada.Tarde}
            };

            Cursos temp = new Cursos{Nombre = "101.Vacaional", Jornada = TiposJornada.Noche};
            escuela.Cursos.AddRange(otraColection);
            escuela.Cursos.Add(temp);

            WriteLine(escuela);
            imprimirCursos(escuela);

            escuela.Cursos.RemoveAll((cur) => cur.Nombre == "501" && cur.Jornada == TiposJornada.Mañana);

            imprimirCursos(escuela);

        }

        private static bool Predicado(Cursos obj)
        {
            return obj.Nombre == "301";
        }

        private static void imprimirCursos(Escuela escuela)
        {
            System.Console.WriteLine("--------------");

            WriteLine("=================");
            WriteLine("Cursos de escuela");
            WriteLine("=================");


            foreach (var curso in escuela.Cursos)
            {
                WriteLine($"Nombre: {curso.Nombre}, ID: {curso.UniqueID}");
            }
        }
    }
}
