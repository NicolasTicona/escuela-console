using System;
using CoreEscuela.Interfaces;
namespace CoreEscuela.Entidades
{
    public class Evaluacion: Model
    {

        public Alumno Alumno {get; set;}
        public Asignatura Asignatura {get; set;}

        public float Nota {get; set;}
        public Evaluacion(string nombre)
        {
            this.Nombre = nombre;
            this.Id = Guid.NewGuid().ToString();
        }
    }
}