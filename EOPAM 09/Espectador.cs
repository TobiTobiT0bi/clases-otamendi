using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOPAM_09
{
    internal class Espectador
    {
        public string _nombre;
        public int _edad;
        public int _dinero;

        public Espectador(string nombre, int edad, int dinero) {
            _nombre = nombre;
            _edad = edad;
            _dinero = dinero;
        }

        public bool comprobarEspectador(Pelicula peli, Cine cine) {
            return _edad >= peli._edadMinima && _dinero >= cine._precio;
        }
    }
}
