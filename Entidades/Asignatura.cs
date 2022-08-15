using System;
namespace CorEscuela.Entidades
{
    public class Asignatura
    {
        public string UniqueID { get; private set; }
        public string Nombre { get; set; }

        public Asignatura(string nombre){

            Nombre = nombre;
            UniqueID = Guid.NewGuid().ToString();

        }
        
    }
    
}