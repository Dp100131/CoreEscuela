using System;
namespace CorEscuela.Entidades
{
    public class Evaluaciones
    {
        public string UniqueID { get; private set; }
        public string Nombre { get; set; }
        public Asignatura Asignatura {get; set;}
        public double Nota {get; set;}
        public Evaluaciones(Asignatura asignatura, string nombre, double nota){

            Asignatura = asignatura;
            Nombre = nombre;
            Nota = nota;
            UniqueID = Guid.NewGuid().ToString();

        }
        
    }
    
}