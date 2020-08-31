using System.Collections.Generic;
using System.Linq;
using System;
using CoreEscuela.Entidades;
using CoreEscuela.Util;
namespace CoreEscuela
{
    public class EscuelaEngine
    {
        public Escuela Escuela { get; set; }

        public EscuelaEngine()
        {
        }

        public void Inicializar()
        {
            this.Escuela = new Escuela("Latino", 2010, "Peru", "Lima");

            CargarCursos();
            CargarAsignaturas();
            CargarEvaluaciones();
            CargarNotas();
            VerDatosEscuela();
        }

        public void CargarCursos()
        {
            this.Escuela.Cursos = new List<Curso>(){
                new Curso("101"),
                new Curso("102"),
                new Curso("103")
            };

            Random random = new Random();
            foreach (var curso in Escuela.Cursos)
            {
                curso.Alumnos = GenerarAlumnos(2);
            }
        }
        public List<Alumno> GenerarAlumnos(int cantidad = 3)
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var listaAlumnos = 
                from n1 in nombre1
                from n2 in nombre2
                from a1 in apellido1
                select new Alumno($"{n1} {n2} {a1}");

            return listaAlumnos
                    .OrderBy((al) => al.Id)
                    .Take(cantidad)
                    .ToList();
        }
        public void CargarAsignaturas()
        {
            foreach(var curso in Escuela.Cursos)
            {
                List<Asignatura> listaAsignatura = new List<Asignatura>(){
                    new Asignatura("Matematica"),
                    new Asignatura("Comunicacion"),
                    new Asignatura("Ciencias")
                };
                curso.Asignaturas = listaAsignatura;
            }

        }

        public void CargarEvaluaciones()
        {
            string[] evaluaciones = {"Eval #1", "Eval #2", "Eval #3", "Eval #4", "Eval #5"};

            Random rdn = new Random();

            foreach(var curso in this.Escuela.Cursos)
            {
                foreach(var asig in curso.Asignaturas)
                {
                    int cantidad = rdn.Next(0, 2);

                    if(cantidad > 0)
                    {
                        for(var i  = 0; i < cantidad; i++)
                        {
                            var pos = rdn.Next(0, 5);
                            asig.Evaluaciones.Add(evaluaciones[pos]);
                        }
                    }
                    else
                    {
                        asig.Evaluaciones.Add(evaluaciones[0]);
                    }

                }
            }
        }

        public void CargarNotas()
        {
            Random rdn = new Random();

            foreach(var curso in this.Escuela.Cursos)
            {
                foreach(var alum in curso.Alumnos)
                {
                    foreach(var asig in curso.Asignaturas)
                    {
                        foreach(var eval in asig.Evaluaciones)
                        {
                            int cantEvals = asig.Evaluaciones.ToArray().Length;
                            List<int> notas = new List<int>();

                            for(var i = 0; i < cantEvals; i++)
                            {
                                int number = rdn.Next(0, 5);
                                notas.Add(number);
                            }

                            alum.Notas.Add(new Nota(eval, notas));
                        }
                    }
                }
            }
        }

        public void VerDatosEscuela()
        {
            foreach(var curso in this.Escuela.Cursos)
            {
                foreach(var alumno in curso.Alumnos)
                {
                    Console.WriteLine("Estudiante");
                    Console.WriteLine(alumno.Nombre);
                    Console.WriteLine($"Evaluaciones para {curso.Nombre}");
                    
                    foreach(var eval in alumno.Notas)
                    {
                        Printer.Linea();
                        Console.WriteLine(eval.EvaluacionNombre);
                        foreach(var nota in eval.Notas)
                        {
                            Console.WriteLine(nota);
                        }
                        Console.Write("///");
                    }

                    Printer.Linea();
                }
            }
        }


    }
} 