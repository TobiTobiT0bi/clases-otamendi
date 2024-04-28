using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOPAM_13
{
    internal class Repartidor : Empleado
    {
        string zona = "";

        public Repartidor(string nombre, int edad, int salario, string zona) : base(nombre, edad, salario)
        {
            this.zona = zona;
        }

        public string _zona
        {
            get { return zona; }
            set { zona = value; }
        }

        public override bool plus()
        {
            if (_edad > 25 && zona == "zona 3") {
                _salario += PLUS;
                return true;
            }
            return false;
        }
    }
}
