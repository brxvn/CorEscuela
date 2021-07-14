using System;
using System.Collections.Generic;

namespace CorEscuela.Entidades
{
    public class Alumno
    {
        public string UniqueID { get; private set; }
        public string Nombre { get; set; }
        public List<Evaluaciones> Evaluaciones {get; set;}

        public Alumno(){
            this.UniqueID = Guid.NewGuid().ToString();
            this.Evaluaciones = new List<Evaluaciones>(){};
        }
            
               
    }
}