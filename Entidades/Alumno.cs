using System;
namespace CorEscuela.Entidades
{
    public class Alumno: ObjetoEscuelaBase
    {
        public List<Evaluaciones> Evaluaciones  {get; set;}
        public Alumno(string nombre){

            Nombre = nombre;
            Evaluaciones = new List<Evaluaciones>();

        }
        
    }
    
}