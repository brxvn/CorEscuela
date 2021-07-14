using System;

namespace CorEscuela.Entidades
{
    public class Asignatura
    {
        public string UniqueID { get; private set; }
        public string Nombre { get; set; }

        public Asignatura()=> UniqueID = Guid.NewGuid().ToString();        
    }
}