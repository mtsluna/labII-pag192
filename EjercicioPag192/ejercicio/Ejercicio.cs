using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioPag192.ejercicio
{
    class Ejercicio
    {

        public static int pedirCantidadAlumnos()
        {
            Console.Write("Ingrese la cantidad de alumnos: ");
            return Int32.Parse(Console.ReadLine());
        }

        public static void pedirCalificaciones(int [] calificaciones, int elem)
        {
            Console.Write("Ingrese la nota del "+(elem+1)+"° alumno: ");
            int calificacion = Int32.Parse(Console.ReadLine());
            calificaciones[elem] = calificacion;
        }

        public static void mostrarResumen(int[] cotas, double promedio)
        {
            Console.WriteLine("Nota menor: " + cotas[0]);
            Console.WriteLine("Nota mayor: " + cotas[1]);
            Console.WriteLine("Promedio: " + Math.Round(promedio, 2));
        }

    }
}
