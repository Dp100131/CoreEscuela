using System;
namespace CorEscuela.Entidades
{
    public class Alumno
    {
        public string UniqueID { get; private set; }
        public string Nombre { get; set; }
        public List<Evaluaciones> Evaluaciones  {get; set;}
        public Alumno(string nombre){

            Nombre = nombre;
            Evaluaciones = new List<Evaluaciones>();
            UniqueID = Guid.NewGuid().ToString();

        }
        
    }
    
}