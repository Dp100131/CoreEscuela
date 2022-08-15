using System;
using CorEscuela.Entidades;
using CorEscuela.util;

namespace CorEscuela
{
    class Program
    {
        static void Main(string[] args)
        {   
            var Engine = new EscuelaEngine();
            
            Engine.Inicializar();
            Printer.WriteTitle("Bienvenidos a la Escuela");

            System.Console.WriteLine(Engine.escuela);

            Engine.escuela.ImprimirCursosEscuela();

        }

        
    }
}

/* private static bool Predicado(Curso obj)
        {
            return obj.Nombre == "101-Vacaional";
        } */

/*//removeall

            escuela.Cursos.RemoveAll(Predicado);

            
            escuela.ImprimirCursosEscuela();

            //delegado
            escuela.Cursos.Add(new Curso(){Nombre = "101-Vacaional"});
            escuela.ImprimirCursosEscuela();
            
            escuela.Cursos.RemoveAll(delegate(Curso curso){

                return curso.Nombre == "101-Vacaional";

            });

            escuela.ImprimirCursosEscuela();

            //lamda

            escuela?.Cursos.RemoveAll((Curso curso) =>  curso.Nombre == "501");

            escuela?.ImprimirCursosEscuela();*/
