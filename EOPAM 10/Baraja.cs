using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOPAM_10
{
    internal class Baraja
    {
        string[] palos = {
            "oro",
            "espada",
            "basto",
            "copa"
        };

        public List<string> cartas = new List<string>();
        int pos = 0;

        public Baraja() {
            for (int j = 0; j < 4; j++) {
                for (int i = 1; i < 13; i++) {
                    if (i != 8 && i != 9) {
                        cartas.Add($"{i} de {palos[j]}");
                    }
                }
            }          
        }

        public void Barajar(Random rnd) {
            string puente;
            int indiceR;

            for (int i = pos; i < cartas.Count(); i++) {
                indiceR = rnd.Next(pos, cartas.Count());

                puente = cartas[indiceR];
                cartas[indiceR] = cartas[i];
                cartas[i] = puente;
            }
        }

        public string SiguienteCarta() {
            if (pos < cartas.Count())
            {
                pos++;

                return cartas[pos - 1];
            }
            else {
                return "no more cartiñas";
            }
               
        }

        public string CartasDisponibles() {
            return $"quedan {cartas.Count() - pos} cartas";
        }

        public List<string> MostrarBaraja() {
            List<string> cartasBaraja = new List<string>();

            for (int i = pos; i < cartas.Count(); i++) {
                cartasBaraja.Add(cartas[i]);
            }

            return cartasBaraja;
        }

        public List<string> darCartas(int cant) { 
            List<string> cartasBaraja = new List<string>();
            int poscant = pos + cant;

            if (poscant <= cartas.Count()) {
                for (int i = pos; i < poscant; i++) {
                    cartasBaraja.Add(cartas[i]);
                    pos++;
                }
            }
            else {
                cartasBaraja.Add("No es posible dar las suficientes cartas");
            }
           
            return cartasBaraja;
        }

        public List<string> cartasMonton()
        {
            List<string> cartasBaraja = new List<string>();

            if (pos != 0)
            {
                for (int i = 0; i < pos; i++)
                {
                    cartasBaraja.Add(cartas[i]);
                }
            }
            else
            {
                cartasBaraja.Add("todavia no salieron cartas");
            }

            return cartasBaraja;
        }
    }
}
