using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOPAM_09
{
    internal class Cine
    {
        public string _tituloPelicula;
        public int _precio;

        public Cine(string pelicula, int precio) { 
            _tituloPelicula = pelicula;
            _precio = precio;
        }
    }
}
