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

    public class Cuenta {
        string titular;
        float cantidad;

        public Cuenta(string titu) { 
            titular = titu;
        }


    }

    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
