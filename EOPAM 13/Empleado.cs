using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOPAM_13
{
    internal class Empleado
    {
        string nombre;
        int edad;
        int salario;

        const int pLUS = 300;

        public Empleado(string nombre, int edad, int salario) {
            this.nombre = nombre;
            this.edad = edad;
            this.salario = salario;
        }

        public string _nombre { get { return nombre; } set {  nombre = value; } }
        public int _edad { get {  return edad; } set {  edad = value; } }
        public int _salario { get {  return salario; } set {  salario = value; } }
        public int PLUS { get { return pLUS; } }

        public virtual bool plus() { 
            return true;
            // NO HAY NADA NO VEAS NO HAY NADA QUE TE INTERESA NO ES DE TU INCUMBENCIA 
        }
    }
}
