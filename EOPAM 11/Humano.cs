using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOPAM_11
{
    internal class Humano
    {
        public int dinero;
        public int apuesta;
        string nombre;
        string prediccion;       
        int victorias;
        
        public string Nombre { get { return nombre; } }
        public string Prediccion { get { return prediccion; } }
        public int Victorias { get { return victorias; } }

        public Humano(string nombre) {
            this.nombre = nombre;
            dinero = 15;
            apuesta = 0;
            victorias = 0;
        }

        public void Apostar(Random rnd) {
            dinero--;
            apuesta++;

            prediccion = $"{rnd.Next(0, 4)} - {rnd.Next(0, 4)}";
        }

        public void Ganar() { 
            victorias++;
        }

        public string MostrarTodo() {
            return $"{nombre}, Dinero: {dinero}, apuesta: ${apuesta}, victorias: {victorias}, prediccion: {prediccion}";
        }
    }
}
