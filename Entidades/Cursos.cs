using System;

namespace CorEscuela.Entidades
{
    public class Cursos
    {
        public string Nombre { get; set; }  
        public string UniqueID { get; private set; }
        public TiposJornada Jornada { get; set; }
        
        public Cursos() => UniqueID = Guid.NewGuid().ToString();
            
    }
}