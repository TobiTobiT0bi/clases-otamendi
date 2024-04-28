using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Puedes hacer que devuelva un booleano o que no devuelva nada, lo dejo a tu elección.
//Crea una clase ejecutable donde crees distintos empleados y le apliques el plus para comprobar que funciona.

namespace EOPAM_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            List<Comercial> _comercialLista = new List<Comercial>();
            List<Repartidor> _repartidorLista = new List<Repartidor>();

            for (int i = 0; i < 6; i++) {
                _comercialLista.Add(new Comercial($"pepe{i}", rnd.Next(18, 45), rnd.Next(500, 1001), rnd.Next(150, 301)));
                _repartidorLista.Add(new Repartidor($"pepe{i}", rnd.Next(18, 45), rnd.Next(500, 1001), $"zona {rnd.Next(0, 4)}")); 

                Console.Write($"estado de plus: {_comercialLista[i].plus()}");
            }
        }
    }
}
