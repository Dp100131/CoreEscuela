using CorEscuela.util;
namespace CorEscuela.Entidades
{
    public class Escuela: ObjetoEscuelaBase
    {
        public int AñoDeCreacion {get; set;}
        public string Pais { get; set; }
        public string Ciudad { get; set; }
        public TiposEscuela TipoEscuela { get; set; }
        public List<Curso> Cursos { get; set; }
        public Escuela(string nombre, int año) => (Nombre, AñoDeCreacion) = (nombre, año);
        public Escuela(string nombre, int año, TiposEscuela tipo, string pais="", string ciudad=""){

            (Nombre, AñoDeCreacion) = (nombre, año);
            Pais = pais;
            Ciudad = ciudad;
            TipoEscuela = tipo;

        }

        public override string ToString()
        {
            return $"Contenido: \n\tNombre: {Nombre}.\n\tTipo: {TipoEscuela}.\n\tPais: {Pais}.\n\tCiudad {Ciudad}.";
        }
        public void ImprimirCursosEscuela()
        {
            Printer.WriteTitle("Cursos de la Escuela");

            foreach (var item in this.Cursos)
            {
                Console.WriteLine($"\t{item.Nombre}, {item.UniqueID}.");
            }

        }

    }
}