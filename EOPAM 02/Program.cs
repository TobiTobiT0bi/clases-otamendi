using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

//Haz una clase llamada Persona que siga las siguientes condiciones:
//Sus atributos son: nombre, edad, DNI, sexo (H hombre, M mujer), peso y altura. No queremos que se accedan directamente a ellos. Piensa que modificador de acceso es el más adecuado, también su tipo. Si quieres añadir algún atributo puedes hacerlo.
//Por defecto, todos los atributos menos el DNI serán valores por defecto según su tipo (0 números, cadena vacía para String, etc.). Sexo sera hombre por defecto, usa una constante para ello.
//Se implantaran varios constructores:
//Un constructor por defecto.
//Un constructor con el nombre, edad y sexo, el resto por defecto.
//Un constructor con todos los atributos como parámetro.
//Los métodos que se implementarán son:

//calcularIMC(): calculará si la persona está en su peso ideal (peso en kg/(altura^2  en m)), si esta fórmula devuelve un valor menor que 20, la función devuelve un -1,
//si devuelve un número entre 20 y 25 (incluidos), significa que está por debajo de su peso ideal la función devuelve un 0  y si devuelve un valor mayor que 25 significa que tiene sobrepeso,
//la función devuelve un 1. Te recomiendo que uses constantes para devolver estos valores.

//esMayorDeEdad(): indica si es mayor de edad, devuelve un booleano.

//comprobarSexo(char sexo): comprueba que el sexo introducido es correcto. Si no es correcto, será H. No será visible al exterior.

//generaDNI(): genera un número aleatorio de 8 cifras, genera a partir de este su número su letra correspondiente. Este método será invocado cuando se construya el objeto.
//Puedes dividir el método para que te sea más fácil. No será visible al exterior.

//Métodos set de cada parámetro, excepto de DNI.

//Ahora, crea una clase ejecutable que haga lo siguiente:
//Pide por teclado el nombre, la edad, sexo, peso y altura.
//Crea 3 objetos de la clase anterior, el primer objeto obtendrá las anteriores variables pedidas por teclado, el segundo objeto obtendrá todos los anteriores menos el peso y la altura y el último por defecto, para este último utiliza los métodos set para darle a los atributos un valor.
//Para cada objeto, deberá comprobar si está en su peso ideal, tiene sobrepeso o por debajo de su peso ideal con un mensaje.
//Indicar para cada objeto si es mayor de edad.
//Por último, mostrar la información de cada objeto.
//Puedes usar métodos en la clase ejecutable, para que os sea mas fácil.

namespace EOPAM_02
{
    public class Persona {
        const string sexoConst = "H";       //Constante para sexo 

        string nombre = "";                 //
        int edad = 0;                       //
        int dni;                            //
        string sexo = sexoConst;            //atributos
        double peso = 0;                    //
        double altura = 0;                  //

        public string Nombre { 
            get { return nombre; }      //Creo metodo Get para nombre, de esta manera se va a poder acceder al valor pero no se va a poder modificarlo
        }

        public int Edad
        {
            get { return edad; }      //Creo metodo Get para edad, de esta manera se va a poder acceder al valor pero no se va a poder modificarlo
        }

        public int DNI
        {
            get { return dni; }      //Creo metodo Get para dni, de esta manera se va a poder acceder al valor pero no se va a poder modificarlo
        }
        public string Sexo
        {
            get { return sexo; }      //Creo metodo Get para sexo, de esta manera se va a poder acceder al valor pero no se va a poder modificarlo
        }
        public double Peso
        {
            get { return peso; }      //Creo metodo Get para peso, de esta manera se va a poder acceder al valor pero no se va a poder modificarlo
        }
        public double Altura
        {
            get { return altura; }      //Creo metodo Get para altura, de esta manera se va a poder acceder al valor pero no se va a poder modificarlo
        }

        public Persona(string nombre, int edad, int dni, string sexo, double peso, double altura) {         //Constructor full, recibe toda variable posible y asigna a todos los atributos algo
            this.nombre = nombre;
            this.edad = edad;
            this.dni = dni;
            this.sexo = sexo;
            this.peso = peso;
            this.altura = altura;
        }

        public Persona(string nombre, int edad, string sexo) {                                              //Constructor 2: recibe solo nombre, edad y sexo
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
        }

        public Persona() { }

        public int calcularIMC() {
            double resultado = Peso / (Altura * Altura);

            if (resultado > 20) { 
            
            }
            if (resultado <= 20 && resultado >= 25) { 
            
            }
            if (resultado > 25) { 
            
            }

            return 1;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
