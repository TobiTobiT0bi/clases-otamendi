using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Aula: ID, Max_estudiantes, max_profesores, materia.

namespace EOPAM_08
{
    internal class Aula
    {
        string[] materiasDisponibles = { "matematica", "filosofia", "fisica" };

        int ID;
        int Max_Estudiantes = 25;
        int Max_profesores = 1;
        string materia;
        public bool Clase = false;

        public Aula() {
            Globals.IDaula++;
            ID = Globals.IDaula;
        }

        public Aula(int MaxEstu, string materia, int MaxProfe = 1) {
            Globals.IDaula++;
            ID = Globals.IDaula;

            this.Max_Estudiantes = MaxEstu;
            this.Max_profesores = MaxProfe;
            this.materia = materiaCheck(materia);
        }

        public string GetMateria()
        {
            return this.materia;
        }

        public string materiaCheck(string Materia) {
            //if (materiasDisponibles.Count(mate => mate == Materia) == 1)
            //{
            //    return Materia;
            //}
            //return materiasDisponibles[0];

            return (materiasDisponibles.Count(mate => mate == Materia) == 1) ? Materia : materiasDisponibles[0];
        }
    }
}
