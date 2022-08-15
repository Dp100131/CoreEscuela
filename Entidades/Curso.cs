namespace CorEscuela.Entidades
{
    public class Curso : ObjetoEscuelaBase
    {
        public TiposJornada Jornada { get; set; }
        public List<Asignatura> Asignaturas { get; set; }
        public List<Alumno> Alumnos { get; set; }
        public Curso()
        {
            Asignaturas = new List<Asignatura>();
            Alumnos = new List<Alumno>();
        }
    }
}