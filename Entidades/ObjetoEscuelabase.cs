using System;

namespace CorEscuela.Entidades
{
    public abstract class ObjetoEscuelaBase
    {
        public string UniqueID { get; private set; }
        public string Nombre { get; set; }

        public ObjetoEscuelaBase()
        {   
            UniqueID = Guid.NewGuid().ToString();
        }
    }
}