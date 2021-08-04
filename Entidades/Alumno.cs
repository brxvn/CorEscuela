using System;
using System.Collections.Generic;

namespace CorEscuela.Entidades
{
    public class Alumno : ObjetoEscuelaBase
    {
        public List<Evaluación> Evaluaciones { get; set; }

        public Alumno()
        {
            this.Evaluaciones = new List<Evaluación>() { };
        }
    }
}