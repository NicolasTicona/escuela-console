using System;
using System.Collections.Generic;
using CoreEscuela.Interfaces;
namespace CoreEscuela.Entidades
{
    public class Asignatura: Model
    {
        public List<String> Evaluaciones { get; set; }
        public Asignatura(string nombre)
        {
            this.Nombre = nombre;
            this.Id = Guid.NewGuid().ToString();
            this.Evaluaciones = new List<String>();
        }
    }
}