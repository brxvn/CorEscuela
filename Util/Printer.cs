using static System.Console;
namespace CorEscuela.Util
{
    public static class Printer
    {
        public static void DibujarLinea(int size = 15)
        {
            var linea = new string('-', size);
            WriteLine(linea);
        }

        public static void WriteTitle(string titulo)
        {
            var size = titulo.Length + 4;
            DibujarLinea(size);
            WriteLine($"| {titulo} |");
            DibujarLinea(size);
        }
    }
}