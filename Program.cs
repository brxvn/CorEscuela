using System;
using CorEscuela.Entidades;
using static System.Console;

namespace CorEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Platzi Academy", 2012, TiposEscuela.Primaria, ciudad:"Bogotá");
            
            escuela.Cursos = new Cursos[] {
                new Cursos() {Nombre = "101"},
                new Cursos() {Nombre = "201"},
                new Cursos() {Nombre = "301"}
            };

            
            Console.WriteLine(escuela);
            System.Console.WriteLine("--------------");
            
            WriteLine("=================");
            WriteLine("Cursos de escuela");
            WriteLine("=================");

            imprimirCursos(escuela);

        }

        private static void imprimirCursos(Escuela escuela)
        {
            foreach (var curso in escuela.Cursos)
            {
                WriteLine($"Nombre: {curso.Nombre}, ID: {curso.UniqueID}");
            }
        }
    }
}
