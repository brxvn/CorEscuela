namespace CorEscuela.Entidades
{
    public class Escuela
    {
        public string Nombre { get; set; }
        public int AñoDeCreación { get; set; }
        public string Ciudad { get; set; }
        public string Pais { get; set; }
        public TiposEscuela TipoEscuela { get; set; }
        public Cursos[] Cursos { get; set; }

        //Hay dos maneras de escribir un constructor

        //La clásica
        /*public Escuela(string nombre, int año){
            Nombre = nombre;
            AñoDeCreación = año;
        }*/

        //Esta otra
        public Escuela(string nombre, int añoDeCreación) => (Nombre, AñoDeCreación) = (nombre,añoDeCreación);

        public Escuela(string nombre, int añoDeCreación, TiposEscuela tipo, string pais = "", string ciudad = ""){
            (Nombre, AñoDeCreación) = (nombre, añoDeCreación); // manera de pasar los parámetros por tuplas
            pais = Pais;
            Ciudad = ciudad;
        }

        public override string ToString(){
            return $"Nombre: \"{Nombre}\" \nTipo: {TipoEscuela} {System.Environment.NewLine}Pais: {Pais} \nCiudad: {Ciudad}";
        }

        
    }
}
