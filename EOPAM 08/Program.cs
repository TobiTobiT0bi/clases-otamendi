using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Queremos representar con programación orientada a objetos, un aula con estudiantes y un profesor.
//Tanto de los estudiantes como de los profesores necesitamos saber su nombre, edad y sexo. De los estudiantes, queremos saber también su calificación actual (entre 0 y 10) y del
//profesor que materia da.
//Las materias disponibles son matemáticas, filosofía y física.
//Los estudiantes tendrán un 50% para no ir a clase, por lo que sí hacen faltazo no van a clase pero aunque no vayan quedará registrado en el aula (como que cada uno tiene su sitio).
//El profesor tiene un 20% de no encontrarse disponible (reuniones, baja, etc.)
//Las dos operaciones anteriores deben llamarse igual en Estudiante y Profesor (polimorfismo).
//El aula debe tener un identificador numérico, el número máximo de estudiantes y para que está destinada (matemáticas, filosofía o física). Piensa que más atributos necesita.
//Un aula para que se pueda dar clase necesita que el profesor esté disponible, que el profesor de la materia correspondiente esté en el aula correspondiente (un profesor de
//filosofía no puede dar en un aula de matemáticas) y que haya más del 50% de alumnos.
//El objetivo es crear un aula de alumnos y un profesor y determinar si puede darse clase, teniendo en cuenta las condiciones antes dichas.
//Si se puede dar clase mostrar cuántos alumnos y alumnas (por separado) están aprobados de momento (imaginad que les están entregando las notas).
//NOTA: Los datos pueden ser aleatorios (nombres, edad, calificaciones, etc.) siempre y cuando tengan sentido (edad no puede ser 80 en un estudiante o calificación ser 12).


namespace EOPAM_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) {
                Console.Clear();
                // hay un profesor
                // hay alumnos (varios)
                // hay un salón
                // se cuentan las faltas
                // se da clase

                // va a tener 4 clases: Estudiante, Profesor, Humano, Aula

                // Humano: Nombre, edad, sexo
                // Profesor: (Humano), materia[matematica/filosofia/fisica]
                // Alumno: (Humano), calificacion[0-10]
                // Aula: ID, Max_estudiantes, max_profesores, materia, Clase(bool).

                // Aula.Clase = true ---> Profesor.Falta == false, Aula.Materia == profesor.materia, mas del 50% de alumnos (Count(alu => alu.Falta == false) > (Count(alu) / 2))

                // Humano: Faltar() = x% probabilidades de faltar al curso.
                // Alumno: Humano.Faltar() = modificar probablidades a 50%.
                // Profesor: Humano.Faltar() =  modificar probablidades a 20%. 

                Globals.IDaula = 0;
                Random rnd = new Random();

                Aula aula = new Aula(30, "filosofia");
                Profesor profesor = new Profesor("Raul", 35, "masculino", "filosofia");
                List<Alumno> alumnos = new List<Alumno>();

                for (int i = 0; i < 25; i++)
                {
                    // crear alumno y añadirlo a lista
                    alumnos.Add(new Alumno($"pepe{i + 1}", rnd.Next(12, 36), $"{(rnd.Next(0, 2) == 1 ? "masculino" : "femenino")}"));
                }

                if (profesor.GetFalta() == false && profesor.Materia == aula.GetMateria() && alumnos.Count(alu => alu.Falta == false) > (alumnos.Count() / 2))
                {
                    aula.Clase = true;
                }

                int alumnosAprobados = alumnos.Count(alu => alu.Nota >= 6 && alu.Sexo == "masculino");
                int alumnasAprobadas = alumnos.Count(alu => alu.Nota >= 6 && alu.Sexo == "femenino");

                Console.WriteLine($"{(aula.Clase ? $"Alumnos aprobados: {alumnosAprobados}\nAlumnas aprobadas: {alumnasAprobadas}" : "no se puede dar clase lol")}");

                Console.ReadKey();
            }          
        }
    }
}
