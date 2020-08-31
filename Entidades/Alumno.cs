using System;
using System.Collections.Generic;
using CoreEscuela.Interfaces;
namespace CoreEscuela.Entidades
{
    public class Alumno: Model
    {
        public List<Nota> Notas { get; set; }
        public Alumno(string nombre)
        {
            this.Nombre = nombre;
            this.Id = Guid.NewGuid().ToString();
            this.Notas = new List<Nota>();
        }
    }
}