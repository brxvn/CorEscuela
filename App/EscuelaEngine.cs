using System;
using System.Collections.Generic;
using System.Linq;
using CorEscuela.Entidades;

namespace CorEscuela
{
    public sealed class EscuelaEngine
    {
        public Escuela Escuela { get; set; }

        public EscuelaEngine()
        {
        }
        public void Inicializar()
        {
            Escuela = new Escuela("Platzi Academy", 2012, TiposEscuela.Primaria, ciudad: "Bogotá");

            CargarCursos();
            CargarAsignaturas();
            CargarEvaluaciones();

        }

        private void CargarEvaluaciones()
        {
            foreach (var curso in Escuela.Cursos)
            {
                foreach (var asignatura in curso.Asignaturas)
                {
                    foreach (var alumno in curso.Alumnos)
                    {
                        var rnd = new Random(System.Environment.TickCount);
                        for (int i = 0; i < 5; i++)
                        {
                            var ev = new Evaluación
                            {
                                Asignatura = asignatura,
                                Nombre = $"{asignatura.Nombre} Eval{i + 1}",
                                Nota = (float)(10 * rnd.NextDouble()),
                                Alumno = alumno
                            };
                            alumno.Evaluaciones.Add(ev);
                        }
                    }
                }
            }
        }

        private void CargarAsignaturas()
        {
            foreach (var curso in Escuela.Cursos)
            {
                var listaAsignaturas = new List<Asignatura>(){
                    new Asignatura{Nombre = "Matemáticas"},
                    new Asignatura{Nombre = "Física"},
                    new Asignatura{Nombre = "Química"},
                    new Asignatura{Nombre = "Biología"},
                };
                curso.Asignaturas = listaAsignaturas;
            }
        }

        private List<Alumno> GeneralAlumnosRandomly(int cantidad)
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var listaAlumnos = from n1 in nombre1
                               from n2 in nombre2
                               from a1 in apellido1
                               select new Alumno { Nombre = $"{n1} {n2} {a1}" };

            return listaAlumnos.OrderBy((al) => al.UniqueID).Take(cantidad).ToList();
        }

        private void CargarCursos()
        {
            Escuela.Cursos = new List<Cursos>(){
                new Cursos(){Nombre = "101", Jornada = TiposJornada.Mañana},
                new Cursos(){Nombre = "201", Jornada = TiposJornada.Mañana},
                new Cursos(){Nombre = "301", Jornada = TiposJornada.Mañana},
                new Cursos(){Nombre = "401", Jornada = TiposJornada.Tarde},
                new Cursos(){Nombre = "501", Jornada = TiposJornada.Tarde},
            };

            Random rnd = new Random();

            foreach (var curso in Escuela.Cursos)
            {
                int cantRandom = rnd.Next(5, 20);
                curso.Alumnos = GeneralAlumnosRandomly(cantRandom);
            }
        }
        public List<ObjetoEscuelaBase> GetObjetoEscuelas()
        {
            var lstObj = new List<ObjetoEscuelaBase>();
            lstObj.Add(Escuela);
            lstObj.AddRange(Escuela.Cursos);
            foreach (var curso in Escuela.Cursos)
            {
                lstObj.AddRange(curso.Asignaturas);
                lstObj.AddRange(curso.Alumnos);
                foreach (var alumno in curso.Alumnos)
                {
                    lstObj.AddRange(alumno.Evaluaciones);   
                }
            }

            return lstObj;
        }

    }
}