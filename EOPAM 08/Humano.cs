using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOPAM_08
{
    internal class Humano
    {
        public string Nombre;
        public int Edad;
        public string Sexo;
        public bool Falta;
        public double probabilidadFaltar;

        public Random rnd = new Random();

        public Humano(){
            this.probabilidadFaltar = 0;
            this.Falta = Faltar();
        }

        public Humano(string Nombre, int Edad, string sexo) { 
            this.Nombre = Nombre;
            this.Edad = Edad;
            this.Sexo = sexo;
            this.probabilidadFaltar = 0;
            this.Falta = Faltar();
        }

        public bool Faltar() {
            return (rnd.Next(1, 101) <= probabilidadFaltar);
        }
    }
}
