using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOPAM_12
{
    internal class Jugador
    {
        int id;
        string nombre;
        public bool vivo;

        public Jugador(int id, string nombre, bool vivo) { 
            this.id = id;
            this.nombre = nombre;
            this.vivo = vivo;
        }

        public void Disparar(Revolver r) {
            if (r.Disparar()) { 
                vivo = false;
            }
            r.SiguienteBala();
        }
    }
}
