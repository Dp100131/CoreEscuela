namespace CorEscuela.Entidades
{
    public class Curso
    {
        public string UniqueID { get; private set; }
        public string Nombre { get; set; }
        public TiposJornada Jornada { get; set; }
        public List<Asignatura> Asignaturas {get; set;}
        public List<Alumno> Alumnos {get; set;}
        public Curso()
        {
            UniqueID = Guid.NewGuid().ToString();
        }
    }
}