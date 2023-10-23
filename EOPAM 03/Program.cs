using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Haz una clase llamada Password que siga las siguientes condiciones:
//Que tenga los atributos longitud y contraseña . Por defecto, la longitud sera de 8.
//Los constructores serán los siguiente:
//Un constructor por defecto.
//Un constructor con la longitud que nosotros le pasemos. Generará una contraseña aleatoria con esa longitud.
//Los métodos que implementa serán:
//esFuerte(): devuelve un booleano si es fuerte o no, para que sea fuerte debe tener mas de 2 mayúsculas, mas de 1 minúscula y mas de 5 números.
//generarPassword():  genera la contraseña del objeto con la longitud que tenga.
//Método get para contraseña y longitud.
//Método set para longitud.
//Ahora, crea una clase clase ejecutable:
//Crea un array de Passwords con el tamaño que tu le indiques por teclado.
//Crea un bucle que cree un objeto para cada posición del array.
//Indica también por teclado la longitud de los Passwords (antes de bucle).
//Crea otro array de booleanos donde se almacene si el password del array de Password es o no fuerte (usa el bucle anterior).
//Al final, muestra la contraseña y si es o no fuerte (usa el bucle anterior). Usa este simple formato:
//contraseña1 valor_booleano1
//contraseña2 valor_bololeano2


namespace EOPAM_03
{
    public class Password {
        int longitud;                       // atributos
        string contraseña = string.Empty;   //

        public string Contraseña { get { return contraseña; } }                             //
                                                                                            //métodos get para contraseña y longitud, metodo set para longitud
        public int Longitud { get { return longitud; } set { longitud = value; } }          //

        public Password(int longitud = 8) {                                                 //
            this.longitud = longitud;                                                       //
                                                                                            // Un solo contructor al cual se puede entrar de 2 maneras diferentes, una especificando longitud y otra dejando el parentesis vacio
            generarPassword();                                                              //
        }                                                                                   //

        public bool esFuerte() {                                                                //
            int Mayusculas = 0;                                                                 //
            int Minusculas = 0;                                                                 //
            int Numeros = 0;                                                                    //
                                                                                                //
            for (int i = 0; i < longitud; i++) {                                                //
                if (char.IsUpper(contraseña, i)) {                                              //
                    Mayusculas++;                                                               //
                }                                                                               //
                if (char.IsLower(contraseña, i)) {                                              // Esta funcion comprueba si la contraseña es fuerte al evaluar uno por uno cada uno de sus caracteres y contando cuantos son mayusculas, cuantos son minusculas y cuantos son numeros 
                    Minusculas++;                                                               //
                }                                                                               //
                if (char.IsNumber(contraseña, i)) {                                             //
                    Numeros++;                                                                  //
                }                                                                               //
            }                                                                                   //
                                                                                                //
            return (Mayusculas > 2 && Minusculas > 1 && Numeros > 5) ? true : false;            //
        }                                                                                       //

        public string generarPassword() {
            char[] Uppers = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };   //
            char[] Lowers = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };   //
                                                                                                                                                                    //
            Random rnd = new Random();                                                                                                                              //
            List<char> contraEnProgreso = new List<char>();                                                                                                         //
                                                                                                                                                                    //
            for (int i = 0; i < longitud; i++) {                                                                                                                    //
                int panqueques = rnd.Next(1, 4);                                                                                                                    //                            
                switch (panqueques)                                                                                                                                 //
                {                                                                                                                                                   //
                    case 1:                                                                                                                                         //
                        contraEnProgreso.Add(Uppers[rnd.Next(0, Uppers.Count())]);                                                                                  //
                        break;                                                                                                                                      //
                    case 2:                                                                                                                                         //  Se crea una contraseña en base a 2 arrays, uno de mayusculas y otro de minusculas, se elige de forma 
                        contraEnProgreso.Add(Lowers[rnd.Next(0, Lowers.Count())]);                                                                                  //  aleatoria que caracteres se utilizaran. Luego se confecciona caracter a caracter una contraseña de la longitud
                        break;                                                                                                                                      //  previamente especificada conformada por Mayusculas, minusculas y numeros.
                                                                                                                                                                    //
                    case 3:                                                                                                                                         //
                        contraEnProgreso.Add(Convert.ToChar(Convert.ToString(rnd.Next(0, 10))));                                                                    //
                        break;                                                                                                                                      //
                }                                                                                                                                                   //
            }                                                                                                                                                       //
                                                                                                                                                                    //
            return Convert.ToString(contraEnProgreso.ToArray());                                                                                                    //
        }                                                                                                                                                           //
    }                                                                                                                                                               //

    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
