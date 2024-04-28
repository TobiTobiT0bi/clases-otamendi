using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EOPAM_08
{
    internal class Profesor : Humano 
    {
        string[] materiasDisponibles = { "matematica", "filosofia", "fisica" };

        public string Materia;

        public Profesor() : base() {
            this.probabilidadFaltar = 20;
            this.Falta = this.Faltar();
        }

        public Profesor(string Nombre, int Edad, string Sexo, string Materia) : base(Nombre, Edad, Sexo) {
            this.probabilidadFaltar = 20;
            this.Falta = Faltar();
            this.Materia = MateriaCheck(Materia);
        }

        public bool GetFalta() {
            return this.Falta;
        }
        public string MateriaCheck(string Materia) {
            return (materiasDisponibles.Count(mate => mate == Materia) == 1) ? Materia : materiasDisponibles[0];

            //if (materiasDisponibles.Count(mate => mate == Materia) == 1) {
            //    return Materia;
            //}
            //return materiasDisponibles[0];

            //for (int i = 0; i < materiasDisponibles.Count(); i++) {
            //    if (materiasDisponibles[i] == Materia) {
            //        return Materia;
            //    }
            //}

            //return materiasDisponibles[1];
        }
    }
}
