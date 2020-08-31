using System;
using System.Collections.Generic;
namespace CoreEscuela.Entidades

{
    public class Curso
    {
        public string Nombre { get; private set; }

        public string Id { get; set; }

        public TiposJornada Jornada { get; set; }

        public List<Asignatura> Asignaturas{get; set;}
        public List<Alumno> Alumnos{get; set;}

        public Curso(string nombre)
        {
            this.Nombre = nombre;
            this.Id = Guid.NewGuid().ToString();
        }

    }

}