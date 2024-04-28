using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOPAM_11
{
    internal class Partido
    {
        string resultado;
        Random rnd = new Random();  
        public string Resultado { get { return resultado; } }

        public Partido(){
            resultado = $"{rnd.Next(0, 4)} - {rnd.Next(0, 4)}";
        }
    }
}
