using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOPAM_12
{
    internal class Revolver
    {
        int posCamara;
        int posBala;

        public Revolver(Random rnd) { 
            posCamara = rnd.Next(1, 7);
            posBala = rnd.Next(1, 7);
        }

        public bool Disparar() {
            return posCamara == posBala;
        }

        public void SiguienteBala() {
            if (posCamara < 5)
            {
                posCamara++;
            }
            else {
                posCamara = 1;
            }
        }
    }
}
