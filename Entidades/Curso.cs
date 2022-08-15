using CorEscuela.util;
namespace CorEscuela.Entidades
{
    public class Curso : ObjetoEscuelaBase, ILugar
    {
        public TiposJornada Jornada { get; set; }
        public List<Asignatura> Asignaturas { get; set; }
        public List<Alumno> Alumnos { get; set; }
        public string Dirrecion { get; set; }
        public Curso()
        {
            Asignaturas = new List<Asignatura>();
            Alumnos = new List<Alumno>();
        }
        public void LimpiarLugar(){

            Printer.DrawLine();
            Console.WriteLine("Limpiando Estbablecimiento...");
            Console.WriteLine($"Curso {Nombre} Limpio.");

        }
    }
}