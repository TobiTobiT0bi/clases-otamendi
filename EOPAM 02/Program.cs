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

//generaDNI(): genera un número aleatorio de 8 cifras. Este método será invocado cuando se construya el objeto.
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
        string dni;                         //
        string sexo = sexoConst;            //atributos
        double peso = 0;                    //
        double altura = 0;                  //
        Random rnd = new Random();          //

        public string Nombre {
            get { return nombre; } set{ nombre = value ;}    //Creo metodo Get para nombre, de esta manera se va a poder acceder al valor pero no se va a poder modificarlo
        }

        public int Edad
        {
            get { return edad; }      //Creo metodo Get para edad, de esta manera se va a poder acceder al valor pero no se va a poder modificarlo
        }

        public string DNI
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


        public Persona(string nombre, int edad, double peso, double altura) {         //Constructor full, recibe toda variable posible y asigna a todos los atributos algo
            this.nombre = nombre;
            this.edad = edad;
            this.dni = generarDni();
            this.peso = peso;
            this.altura = altura;
        }

        public Persona(string nombre, int edad) {                                              //Constructor 2: recibe solo nombre, edad y sexo
            this.nombre = nombre;
            this.edad = edad;
            this.dni = generarDni();
        }

        public Persona() { }                                                                                //construtor 3: default (sin atributos)

        public int calcularIMC() {                                                      //Creo funcion que devuelve un INT, el tipo de dato que devuelve se especifica de antemano, el nombre es calcularIMC y no recibe nada por parentesis
            double resultado = Peso / (Altura * Altura);                                //Guardo el resultado de la ecuacion en una variable de tipo double (puede tener coma, no es numero entero) 
            int devuelta = 0;                                                           //ya hay dos if que comprueban si es menor o mayor que 20/25, si no entra en ninguno de esos casos, devuelta va a tener el valor que deberia tener si estuviera ENTRE esos dos numeros

            if (resultado < 20) { 
                devuelta = -1;
            }
            //if (resultado <= 20 && resultado >= 25) {
            //    devuelta = 0;
            //}
            if (resultado > 25) {
                devuelta = 1;
            }

            return devuelta;
        }

        public bool esMayorDeEdad() { 
            return edad > 18 ? true : false;                                            //se utiliza un ternario (foto relacionada) para comprobar si la edad es mayor a dieciocho, en caso de ser true, devuelve true, caso contrario, devuelve false
        }

        void comprobarSexo(char sexo) {
            if (!(sexo == (char)72 || sexo == (char)77))                                //Aca se compureba si el sexo NO es "M" o "H", de ser asi, this.sexo sera asignado con el valor de la constante creada anteriormente
            {                                                                           //El ternario de estos if seria asi: this.sexo = !(sexo == (char)72 || sexo == (char)77) ? sexoConst : Convert.ToString(sexo);
                this.sexo = sexoConst;                                                  //opté por no usar un ternario acá porque tiene varias cosas y recien estamos empezando con ternarios, es mas simple de leer
            }                                                                           //solamente usando if's
            else {
                this.sexo = Convert.ToString(sexo);
            }
        }

        string generarDni() {

            this.sexo = rnd.Next(0, 2) == 1 ? sexoConst : "M";              //se asigna un sexo utilizando una variable random y un ternario
            comprobarSexo(Convert.ToChar(this.sexo));                       //se comprueba si el sexo asignado es valido

            return Convert.ToString(rnd.Next(10000000, 100000000));         // funcion Next() crea un numero MAYOR O IGUAL al minimo y SIEMPRE MENOR al máximo
        }

        public string mostrarTodo() {
            return $"nombre: {nombre}, edad: {edad}, dni: {dni}, sexo: {sexo}, peso: {peso}, altura: {altura}";         //devuelve un string con todos los atributos del objeto
        }
    }

    internal class Program
    {
        static public string mensajeIMC(int numero) {                       // se crea un switch que evalua el numero ingresado por el parentesis y devuelve un mensaje diferente 
            switch (numero)                                                 // en cada caso
            {
                case -1:
                    return "esta flaquito";
                case 0:
                    return "peso ideal";
                case 1:
                    return "chequear profesional de salud";
            }

            return "Error: valor no válido";
        }

        static void Main(string[] args) {
            Console.WriteLine("nombre pls");                                //
            string nombre = Console.ReadLine();                             //
                                                                            //
            Console.WriteLine("edad pls");                                  //
            int edad = Convert.ToInt32(Console.ReadLine());                 //
                                                                            // Recoleccion de datos mediante consola
            Console.WriteLine("peso en kg pls");                            //
            double peso = Convert.ToDouble(Console.ReadLine());             //
                                                                            //
            Console.WriteLine("altura en metros pls");                      //
            double altura = Convert.ToDouble(Console.ReadLine());           //

            Persona juan = new Persona(nombre, edad, peso, altura);         //
            Persona pepe = new Persona(nombre, edad);                       // Creacion de objetos utlizando los constructores de la clase Persona y los datos recolectados
            Persona gabriel = new Persona();                                //

            Console.WriteLine($"juan: {mensajeIMC(juan.calcularIMC())}");           //
            Console.WriteLine($"pepe: {mensajeIMC(pepe.calcularIMC())}");           // se calcula el IMC con una funcion, el resultado de eso es pasado a otra funcion que genera un mensaje en base a ese resultado y se imprime todo por consola
            Console.WriteLine($"gabriel: {mensajeIMC(gabriel.calcularIMC())}");     //

            Console.WriteLine($"{juan.Nombre}: {(juan.esMayorDeEdad() == true ? "es mayor de edad" : "no es mayor de edad")}");                     //
            Console.WriteLine($"{pepe.Nombre}: {(pepe.esMayorDeEdad() == true ? "es mayor de edad" : "no es mayor de edad")}");                     // Se utilizan ternarios y variables para mostrar un mensaje en caso de ser mayor de edad y otro en caso de ser menor de edad
            Console.WriteLine($"{gabriel.Nombre}: {(gabriel.esMayorDeEdad() == true ? "es mayor de edad" : "no es mayor de edad")}");               //

            Console.WriteLine($"{juan.mostrarTodo()}");                             //
            Console.WriteLine($"{pepe.mostrarTodo()}");                             // Se imprime por consola todos los atributos de cada objeto utilizando la funcion mostrarTodo()
            Console.WriteLine($"{gabriel.mostrarTodo()}");                          //

            Console.ReadKey();

        }
    }
}
