using System;
using System.Collections.Generic;
using CoreEscuela.Interfaces;

namespace CoreEscuela.Entidades
{
    public class Escuela: Model
    {
        // Getters & Setters
        public int AñoCreacion{get; set;}

        public string Pais{get; set;}

        public string Ciudad{get;set;}

        public TiposEscuela TipoEscuela{get;set;}

        public List<Curso> Cursos { get; set; }

        public Escuela(string nombre, int añoCreacion, string pais, string ciudad)
        {
            this.Id = Guid.NewGuid().ToString();
            this.Nombre = nombre;
            this.AñoCreacion = añoCreacion;
            this.Pais = pais;
            this.Ciudad = ciudad;
            this.TipoEscuela = TiposEscuela.PreEscolar;
        }

        public Escuela(string nombre, TiposEscuela tipo, string pais = "")
        {
            (Nombre, TipoEscuela, Pais) = (nombre, tipo, pais);
        } 

        public override string ToString()
        {
            return $"Nombre {this.Nombre}, Tipo {TipoEscuela}, Pais {Pais}, Ciudad {Ciudad}";
        }
    }
}