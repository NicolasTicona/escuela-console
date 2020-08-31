using System;
using CoreEscuela.Entidades;
using CoreEscuela.Util;
using static System.Console;

namespace CoreEscuela
{

    class Program
    {
        static void Main(string[] args)
        {
            var Engine = new EscuelaEngine();
            Engine.Inicializar();

            Printer.Linea();

            // ImprimirCursos(Engine.Escuela);            
        }

        public static void ImprimirCursos(Escuela escuela)
        {
            if(escuela?.Cursos != null){

                foreach(var curso in escuela.Cursos){
                            
                    Printer.Linea();
                    WriteLine($"{curso.Nombre} {curso.Id}");
                }
            }
        }
    }

}
