using System.Collections.Generic;
using CorEscuela.Entidades;

namespace CorEscuela
{
    public class EscuelaEngine
    {
        public Escuela Escuela { get; set; }

        public EscuelaEngine()
        {
        }

        public void Inicializar()
        {
            Escuela = new Escuela("Platzi Academy", 2012, TiposEscuela.Primaria, ciudad: "Bogotá");

            Escuela.Cursos = new List<Cursos>(){
                new Cursos(){Nombre = "101", Jornada = TiposJornada.Mañana},
                new Cursos(){Nombre = "201", Jornada = TiposJornada.Mañana},
                new Cursos(){Nombre = "301", Jornada = TiposJornada.Mañana},
                new Cursos(){Nombre = "401", Jornada = TiposJornada.Tarde},
                new Cursos(){Nombre = "501", Jornada = TiposJornada.Tarde},
            };
        }
    }

}