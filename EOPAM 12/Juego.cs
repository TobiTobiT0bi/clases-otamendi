using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOPAM_12
{
    internal class Juego
    {
        Random rnd = new Random();
        public bool activo = true;
        List<Jugador> Jugadores;
        Revolver revolver;

        public Juego(int numeroJug)
        {
            numeroJug = numeroJug > 6 || numeroJug < 1 ? numeroJug > 6 ? 6 : 1 : numeroJug;

            Jugadores = new List<Jugador>();
            revolver = new Revolver(rnd);

            for (int i = 0; i < numeroJug; i++) {
                Jugadores.Add(new Jugador(i, $"jugador{i + 1}", true));
            }
        }

        public List<string> Ronda() {
            List<string> jugadoresVivos = new List<string>();

            for (int i = 0; i < Jugadores.Count(); i++) {
                Jugadores[i].Disparar(revolver);
                jugadoresVivos.Add((Jugadores[i].vivo ? "sigue vivito y coleando" : "estqa muerto :(((((((((("));

                if (!Jugadores[i].vivo) {
                    FinJuego();
                }
            }

            return jugadoresVivos;
        }

        public void FinJuego(){
            activo = false;
        }
    }
}
