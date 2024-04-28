using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Vamos a hacer una baraja de cartas españolas orientado a objetos.
//Una carta tiene un número entre 1 y 12 (el 8 y el 9 no los incluimos) y un palo (espadas, bastos, oros y copas)
//La baraja estará compuesta por un conjunto de cartas, 40 exactamente.
//Las operaciones que podrá realizar la baraja son:
//barajar(): cambia de posición todas las cartas aleatoriamente
//siguienteCarta(): devuelve la siguiente carta que está en la baraja, cuando no haya más o se haya llegado al final, se indica al usuario que no hay más cartas.
//cartasDisponibles(): indica el número de cartas que aún puede repartir
//darCartas(): dado un número de cartas que nos pidan, le devolveremos ese número de cartas (piensa que puedes devolver). En caso de que haya menos cartas que las pedidas,
//no devolveremos nada pero debemos indicarlo al usuario.
//cartasMonton(): mostramos aquellas cartas que ya han salido, si no ha salido ninguna indicárselo al usuario
//mostrarBaraja(): muestra todas las cartas hasta el final. Es decir, si se saca una carta y luego se llama al método, este no mostrará esa primera carta.


namespace EOPAM_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo teclado = new ConsoleKeyInfo();
            Baraja baraja = new Baraja();
            Random rnd = new Random();
            
            Console.WriteLine("| ¿Qué vas a hacer?" +
            "\n| 1. Barajar las cartas." +
            "\n| 2. Pedir la siguiente carta." +
            "\n| 3. Ver las cartas disponibles." +
            "\n| 4. Ver la baraja de cartas." +
            "\n| 5. Dar las cartas." +
            "\n| 6. Ver si ya han salido cartas.\n" +
            "");

            while (true)
            {
                Console.Write("input: ");
                teclado = Console.ReadKey(true);

                if (teclado.Key == ConsoleKey.D1 || teclado.Key == ConsoleKey.NumPad1)
                {
                    Console.WriteLine("barajando...");
                    baraja.Barajar(rnd);
                    Console.WriteLine("baraja terminada.");
                }
                if (teclado.Key == ConsoleKey.D2 || teclado.Key == ConsoleKey.NumPad2)
                {
                    Console.WriteLine($"siguiente carta: {baraja.SiguienteCarta()}");
                }
                if (teclado.Key == ConsoleKey.D3 || teclado.Key == ConsoleKey.NumPad3)
                {
                    Console.WriteLine(baraja.CartasDisponibles());
                }
                if (teclado.Key == ConsoleKey.D4 || teclado.Key == ConsoleKey.NumPad4)
                {
                    List<string> restantes = baraja.MostrarBaraja();

                    Console.WriteLine("cartas restantes en la baraja: ");
                    for (int i = 0; i < restantes.Count(); i++)
                    {
                        Console.WriteLine(restantes[i]);
                    }
                }
                if (teclado.Key == ConsoleKey.D5 || teclado.Key == ConsoleKey.NumPad5)
                {
                    Console.WriteLine("Cuantas cartas?");
                    int cantidad = Convert.ToInt32(Console.ReadLine());

                    List<string> devolucion = baraja.darCartas(cantidad);

                    for (int i = 0; i < devolucion.Count(); i++)
                    {
                        Console.WriteLine(devolucion[i]);
                    }
                }
                if (teclado.Key == ConsoleKey.D6 || teclado.Key == ConsoleKey.NumPad6)
                {
                    List<string> monton = baraja.cartasMonton();

                    for (int i = 0; i < monton.Count(); i++)
                    {
                        Console.WriteLine(monton[i]);
                    }
                }

                Console.ReadKey(true);
            }            
        }
    }
}
