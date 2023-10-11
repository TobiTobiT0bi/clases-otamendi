using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Crea una clase llamada Cuenta que tendrá los siguientes atributos: titular y cantidad (puede tener decimales).
//El titular será obligatorio y la cantidad es opcional. Crea dos constructores que cumplan lo anterior.
//Tendrá dos métodos especiales:
//ingresar(double cantidad): se ingresa una cantidad a la cuenta, si la cantidad introducida es negativa, no se hará nada.
//retirar(double cantidad): se retira una cantidad a la cuenta, si restando la cantidad actual a la que nos pasan es negativa, la cantidad de la cuenta pasa a ser 0.

namespace ClasesOtamendi
{
    public class Cuenta { // defino que estoy creando una clase y abro llaves

        public string titular;     // defino los ATRIBUTOS de la clase
        public float cantidad;

        public Cuenta(string titu, float cant) {  // constructor 1: Al ser titular obligatorio está en todos los costructores, al ser cantidad opcional NO esta en todos los costructores
            titular = titu;
            cantidad = cant;
        }

        public Cuenta(string titu) {              // constructor 2: Al ser titular obligatorio está en todos los costructores, al ser cantidad opcional NO esta en todos los costructores
            titular = titu;
        }

        public void Ingresar(double cantidadIntro) {
            if (cantidadIntro > 0) {                                        //Se nos pide evaluar si la cantidad introducida es negativa, y de este ser el caso, no hacer nada.
                                                                            //Como no hacemos nada SI Y SOLO SI la cantidad es negativa, deberemos actuar solo SI Y SOLO SI la cantidad introducida es positiva

                cantidad = cantidad + Convert.ToSingle(cantidadIntro);      //Hacemos la sumatoria de las 2 cantidades y guardamos el resultado en el atributo "cantidad" de la clase (2 maneras de hacerlo)
                // cantidad += Convert.ToSingle(cantidadIntro);
            }
        }

        public void Retirar(double cantidadIntro) {
            if (cantidadIntro < cantidad) {                                 //Para saber si al restar la cantidad introducida el resultado va a ser negativo, comprobamos si la cantidad introducida es mayor a la cantidad actual.


                cantidad = cantidad - Convert.ToSingle(cantidadIntro);      //Hacemos la resta de las 2 cantidads y guardamos el resultado en atributo "cantidad" de la calse (2 maneras de hacerlo)
                // cantidad -= Convert.ToSingle(cantidadIntro); 
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args) {
            Cuenta pepe = new Cuenta("pepe", 500f);                          //Se crea objeto de clase "Cuenta", primero se define (lado izquierdo del =) y despues se INSTANCIA (lado derecho del =) entrando a uno de sus constructores

            Console.WriteLine(pepe.cantidad);
            Console.WriteLine("Cantidad sin modificar\n\n");                 //Accede al atributo cantidad del objeto pepe y lo muestra por consola

            Console.Write("Cantidad a ingresar: ");
            pepe.Ingresar(Convert.ToDouble(Console.ReadLine()));             //Se lee por consola la cantidad introducida por el usuario, esa cantidad es transformada a double (porque la funcion utilizada devuelve string) y pasada al metodo Ingresar()
            Console.WriteLine(pepe.cantidad);                                //Accede al atributo cantidad del objeto pepe y lo muestra por consola

            Console.Write("Cantidad a retirar: ");
            pepe.Retirar(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine(pepe.cantidad);                                //Accede al atributo cantidad del objeto pepe y lo muestra por consola

            Console.ReadKey();
        }
    }
}
