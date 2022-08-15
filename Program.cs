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

            Printer.DrawLine(20);
            Printer.DrawLine(20);
            Printer.DrawLine(20);
            Printer.WriteTitle("Pruebas de polimorfismo");

            var alumnoTest = new Alumno("Clarie UnderWood");

            ObjetoEscuelaBase obj = alumnoTest;

            Printer.WriteTitle("Alumno");
            System.Console.WriteLine($"Alumno: {alumnoTest.Nombre}.");
            System.Console.WriteLine($"ID: {alumnoTest.UniqueID}");
            System.Console.WriteLine($"Type: {alumnoTest.GetType()}");

            Printer.WriteTitle("ObjetoEscuelaBase");
            System.Console.WriteLine($"Alumno: {obj.Nombre}.");
            System.Console.WriteLine($"ID: {obj.UniqueID}");
            System.Console.WriteLine($"Type: {obj.GetType()}");

            var objDummy = new ObjetoEscuelaBase(){Nombre="Frank UnderWood"};
            
            Printer.WriteTitle("ObjetoEscuelaBaseDummy");
            System.Console.WriteLine($"Alumno: {objDummy.Nombre}.");
            System.Console.WriteLine($"ID: {objDummy.UniqueID}");
            System.Console.WriteLine($"Type: {objDummy.GetType()}");

            alumnoTest = (Alumno)objDummy;//No es lo mismo
            System.Console.WriteLine($"Alumno: {alumnoTest.Nombre}.");
            System.Console.WriteLine($"ID: {alumnoTest.UniqueID}");
            System.Console.WriteLine($"Type: {alumnoTest.GetType()}");

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
