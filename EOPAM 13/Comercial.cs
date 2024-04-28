using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOPAM_13
{
    internal class Comercial : Empleado
    {
        double comision = 0;

        public Comercial(string nombre, int edad, int salario, double comision) : base(nombre, edad, salario) {
            this.comision = comision;
        }

        public double _comision {
            get { return comision; } set { comision = value; }
        }
    }
}
