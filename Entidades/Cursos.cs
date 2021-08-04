using System;
using System.Collections.Generic;

namespace CorEscuela.Entidades
{
    public class Cursos : ObjetoEscuelaBase
    {
        public TiposJornada Jornada { get; set; }
        public List<Asignatura> Asignaturas { get; set; }
        public List<Alumno> Alumnos { get; set; }         
    }
}