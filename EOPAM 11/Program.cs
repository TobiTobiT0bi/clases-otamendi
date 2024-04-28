using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Estando en un grupo de amigos, se planea hacer una porra de la liga de fútbol. A nosotros se nos ocurre hacer un programa en POO para simular cómo podría desarrollarse la apuesta.
//Cada jugador que participa de la apuesta, pone un 1 euro para cada jornada y decide el resultado de los partidos acordados.
//Si nadie acierta en una jornada los resultados, el pozo se acumula.
//En principio, deben acertar el resultado de dos partidos para llevarse el dinero del acumulado de la apuesta.
//Todos empiezan con un dinero inicial que será decidido por el programador (ya sea como parámetro o como constante). Si el jugador no tiene dinero en una jornada no podrá participar de la apuesta.
//Para esta versión, entre jugadores podrán repetir resultados repetidos, por lo que el jugador que primero diga ese resultado (tal como están de orden) se llevará primero el pozo de dinero.
//Los resultados de la apuesta serán generados aleatoriamente, tanto los de jugador como los de los partidos (no es necesario nombre, solo resultados).
//Al final del programa, se deberá mostrar el dinero que tienen los jugadores y el número de veces que han ganado.
//Para este ejercicio, recomiendo usar interfaces (no hablo de interfaces gráficas) para las constantes y métodos que sean necesarios.


namespace EOPAM_11
{
    internal class Program
    {
        static bool Gano(Partido par, Humano hum) {
            return hum.Prediccion == par.Resultado;
        }

        static void Main(string[] args)
        {
            List<Humano> jugadores = new List<Humano>();
            int pozo = 0;
            int lastPozo = 0;
            Random rnd = new Random();

            jugadores.Add(new Humano("juan"));
            jugadores.Add(new Humano("pepe"));
            jugadores.Add(new Humano("geronimo"));
            jugadores.Add(new Humano("floppa"));

            Console.WriteLine("Cuantas rondas? ");
            int rondas = Convert.ToInt16(Console.ReadLine());

            for (int j = 0; j < rondas; j++) {
                Console.Clear();
                Partido partido = new Partido();

                for (int i = 0; i < jugadores.Count(); i++)
                {
                    if (jugadores[i].dinero > 0)
                    {
                        jugadores[i].Apostar(rnd);
                    }
                }

                bool yaGanaron = false;
                lastPozo = pozo;

                for (int i = 0; i < jugadores.Count(); i++)
                {
                    Console.Write("\n" + jugadores[i].MostrarTodo());
                    if (Gano(partido, jugadores[i]) && !yaGanaron)
                    {
                        jugadores[i].dinero += pozo;
                        jugadores[i].Ganar();
                        pozo = 0;
                        yaGanaron = true;
                        Console.Write(" GANADOR");
                    }
                    else
                    {
                        pozo += jugadores[i].apuesta;                        
                    }
                    jugadores[i].apuesta = 0;
                }

                Console.WriteLine("\n" + $"resultado del partido: {partido.Resultado}, pozo: {(yaGanaron ? lastPozo : pozo)}");
                Console.ReadKey();
            }                       
        }
    }
}
