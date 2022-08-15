using CorEscuela.Entidades;

namespace CorEscuela
{
    public class EscuelaEngine
    {
        public Escuela escuela {get; set;}

        public EscuelaEngine(){

            
        }

        public void Inicializar()
        {

            escuela = new Escuela("uis academy", 2022, TiposEscuela.Secundaria, "Colombia", "Bucarmanga");
            CargarCursos();
            CargarAsignaturas();
            CargarAlumnos();    
            CargarEvaluaciones();

        }

        private void CargarAlumnos()
        {
            Random rnd = new Random();

            foreach (var curso in escuela.Cursos)
            {
                int cantRandom = rnd.Next(5, 20);
                curso.Alumnos = CrearAlumnosAlAzar(cantRandom);
            }
        }

        private List<Alumno> CrearAlumnosAlAzar(int cantidad)
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var listaAlumnos =  from n1 in nombre1
                                from n2 in apellido1
                                from a1 in apellido1
                                from a2 in apellido1
                                select new Alumno($"{n1} {n2} {a1} {a2}");
            
            return listaAlumnos.OrderBy((al)=> al.UniqueID).Take(cantidad).ToList();


        }

        private void CargarAsignaturas()
        {
            foreach (var curso in escuela.Cursos)
            {
                List<Asignatura> listaAsignaturas = new List<Asignatura>(){

                    new Asignatura("Matemáticas"),
                    new Asignatura("Educación física"),
                    new Asignatura("Castellano"),
                    new Asignatura("Ciencias Naturales")

                };
                curso.Asignaturas = listaAsignaturas;
            }
        }

        private void CargarEvaluaciones()
        {
            foreach (var curso in escuela.Cursos)
            {
                foreach (var asignatura in curso.Asignaturas)
                {
                    foreach (var alumno in curso.Alumnos)
                    {
                        var rnd = new Random(System.Environment.TickCount);
                        for (int i = 0; i < 5; i++)
                        {
                            Asignatura Asignatura = asignatura;
                            string Nombre = $"{asignatura.Nombre} Ev#{i+1}";
                            double Nota = (5 * rnd.NextDouble());
                            var ev = new Evaluaciones(Asignatura, Nombre, Nota);
                            alumno.Evaluaciones.Add(ev);
                        }
                    }
                }
            }
        }

        private void CargarCursos()
        {
            escuela.Cursos = new List<Curso> {

                        new Curso() {Nombre = "101"},
                        new Curso() {Nombre = "201"},
                        new Curso() {Nombre = "301"},
                        new Curso() {Nombre = "401"},
                        new Curso() {Nombre = "501"},
                        new Curso() {Nombre = "502"},
                        new Curso() {Nombre = "102"}
            };
        }
    }
}