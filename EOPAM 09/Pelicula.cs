using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOPAM_09
{
    internal class Pelicula
    {
        public string _titulo;
        public int _duracion;
        public int _edadMinima;
        public string _director;

        public Pelicula(string titulo, int duracion, int edadMinima, string director) { 
            _titulo = titulo;
            _duracion = duracion;
            _edadMinima = edadMinima;
            _director = director;
        }
    }
}
