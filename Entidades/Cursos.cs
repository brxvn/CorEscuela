using System;
using System.Collections.Generic;

namespace CorEscuela.Entidades
{
    public class Cursos
    {
        public string Nombre { get; set; }  
        public string UniqueID { get; private set; }
        public TiposJornada Jornada { get; set; }
        public List<Asignatura> Asignaturas { get; set; };
        public List<Alumno> Alumnos { get; set; };
        
        public Cursos() => UniqueID = Guid.NewGuid().ToString();
            
    }
}