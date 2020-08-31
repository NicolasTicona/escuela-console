using System.Collections.Generic;

namespace CoreEscuela.Entidades
{
    public class Nota
    {
        public string EvaluacionNombre { get; set; }

        public List<int> Notas {get; set;}

        public Nota(string evaluacionNombre, List<int> notas)
        {
            this.EvaluacionNombre = evaluacionNombre;
            this.Notas = notas;
        }
    }
}