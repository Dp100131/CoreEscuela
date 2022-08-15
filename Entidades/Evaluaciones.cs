using System;
namespace CorEscuela.Entidades
{
    public class Evaluaciones: ObjetoEscuelaBase
    {
        public Asignatura Asignatura {get; set;}
        public double Nota {get; set;}
        public Evaluaciones(Asignatura asignatura, string nombre, double nota){

            Asignatura = asignatura;
            Nombre = nombre;
            Nota = nota;

        }
        
    }
    
}