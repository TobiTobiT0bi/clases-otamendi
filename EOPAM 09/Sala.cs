using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOPAM_09
{
    internal class Sala
    {
        public bool[,] asientos = new bool[9, 8];

        public Sala() {
            for(int columnas = 0; columnas < 9; columnas++) {
                for (int filas = 0; filas < 8; filas++) {
                    asientos[columnas, filas] = false;
                }
            }
        }
    }
}
