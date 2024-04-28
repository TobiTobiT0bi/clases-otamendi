using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Nos piden hacer un programa orientado a objetos sobre un cine (solo de una sala) tiene un conjunto de asientos (8 filas por 9 columnas, por ejemplo).
//Del cine nos interesa conocer la película que se está reproduciendo y el precio de la entrada en el cine.
//De las películas nos interesa saber el título, duración, edad mínima y director.
//Del espectador, nos interesa saber su nombre, edad y el dinero que tiene.
//Los asientos son etiquetados por una letra (columna) y un número (fila), la fila 1 empieza al final de la matriz como se muestra en la tabla. También deberemos saber si
//está ocupado o no el asiento.

//8A 8B 8C 8D 8E 8F 8G 8H 8I
//7A 7B 7C 7D 7E 7F 7G 7H 7I
//6A 6B 6C 6D 6E 6F 6G 6H 6I
//5A 5B 5C 5D 5E 5F 5G 5H 5I
//4A 4B 4C 4D 4E 4F 4G 4H 4I
//3A 3B 3C 3D 3E 3F 3G 3H 3I
//2A 2B 2C 2D 2E 2F 2G 2H 2I
//1A 1B 1C 1D 1E 1F 1G 1H 1I

//Realizaremos una pequeña simulación, en el que generamos muchos espectadores y los sentamos aleatoriamente (no podemos donde ya esté ocupado).
//En esta versión sentaremos a los espectadores de uno en uno.
//Solo se podrá sentar si tienen el suficiente dinero, hay espacio libre y tiene edad para ver la película, en caso de que el asiento esté ocupado le buscamos uno libre.
//Los datos del espectador y la película pueden ser totalmente aleatorios.


namespace EOPAM_09
{
    internal class Program
    {
        static void dibujarCatto(int coordenadaX, int coordenadaY) {
            Console.SetCursorPosition(coordenadaX, coordenadaY);
            Console.Write("/\\_/\\");
            Console.SetCursorPosition(coordenadaX - 1, coordenadaY + 1);
            Console.Write("( o.o )");
            Console.SetCursorPosition(coordenadaX, coordenadaY + 2);
            Console.Write("> ^ <");
        }

        static void Graficar(Sala sala)
        {
            char[] letras = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I' };
            int espaciado = 10;

            for (int columna = 0; columna < sala.asientos.GetLength(0); columna++) {
                for (int fila = sala.asientos.GetLength(1); fila > 0; fila--) {
                    Console.SetCursorPosition(espaciado + columna, 18 - fila);
                    Console.ForegroundColor = !sala.asientos[columna,fila - 1] ? ConsoleColor.Green : ConsoleColor.Red;

                    Console.Write($"{fila}{letras[columna]}");
                }
                espaciado = espaciado + 3;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            dibujarCatto(110, 1);
        }

        static string Evaluar(List<Espectador> espectadores, Cine cine, Pelicula peli, Sala sala) {
            Random rnd = new Random();

            for (int i = 0; i < espectadores.Count; i++) {
                if(espectadores[i].comprobarEspectador(peli, cine)){
                    while(true)
                    {
                        int columna = rnd.Next(0, 9);
                        int fila = rnd.Next(0, 8);

                        if (!sala.asientos[columna, fila])
                        {
                            sala.asientos[columna, fila] = true;
                            break;
                        }
                        else{
                            int contador = 0;

                            for (int j = 0; j < sala.asientos.GetLength(0); j++) {
                                for (int l = 0; l < sala.asientos.GetLength(1); l++) {
                                    if (!sala.asientos[j, l]) {
                                        contador++;
                                    }
                                }
                            }

                            if (contador == 0) {
                                return "asientos agotados";
                            }                            
                        }
                    }
                }
            }
            return "fila agotada";           
        }

        static void Main(string[] args)
        {
            // 4 clases: Pelicula, espectador, cine, sala;

            // Cine: nombrePelicula, precio;
            // Pelicula: Titulo, duracion, edadMinima, director;
            // Espectador: Edad, dinero, nombre;
            // Sala: array(fila, columna)

            // generar asientos, espectadores, peliculas y cine
            // comprobar todos y cada uno de los espectadores a los requisitos de la pelicula hasta llenar el cine o hasta terminar espectadores
            Console.CursorVisible = false;

            List<Espectador> _espectadores = new List<Espectador>();
            Random rnd = new Random();
            Cine cine = new Cine("Prometeo Cines", 90);
            Pelicula pelicula = new Pelicula("Deadpool 3", 120, 16, "Shawn Levy"); 
            Sala sala = new Sala();
            string msj = "";

            for (int i = 0; i < 120; i++)
            {
                _espectadores.Add(new Espectador("Floppa", rnd.Next(1, 81), rnd.Next(1, 201)));
            }

            for(int i = 0; i < 2; i++) {
                Graficar(sala);
                Console.SetCursorPosition(10, 5);
                msj = Evaluar(_espectadores, cine, pelicula, sala);
                if (i == 0) {
                    Console.WriteLine(msj);
                }               
                Console.ReadKey(true);
                Console.Clear();
            }        
        }
    }
}
