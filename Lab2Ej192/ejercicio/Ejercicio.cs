using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioPag192.ejercicio
{
    class Ejercicio
    {

        public static void exec()
        {
            int n = pedirCantidadAlumnos();
            int[] calificaciones = new int[n];
            for (int i = 0; i < n; i++)
            {
                pedirCalificaciones(calificaciones, i);
            }
            double promedio = calcularPromedio(calificaciones);
            int[] cotas = encontrarCotas(calificaciones);
            mostrarResumen(cotas, promedio);
        }

        public static int pedirCantidadAlumnos()
        {
            Console.Write("Ingrese la cantidad de alumnos: ");
            return Int32.Parse(Console.ReadLine());
        }

        public static void pedirCalificaciones(int[] calificaciones, int elem)
        {
            Console.Write("Ingrese la nota del " + (elem + 1) + "° alumno: ");
            int calificacion = Int32.Parse(Console.ReadLine());
            calificaciones[elem] = calificacion;
        }

        public static double calcularPromedio(int[] calificaciones)
        {
            int total = 0;
            for (int i = 0; i < calificaciones.Length; i++)
            {
                total += calificaciones[i];
            }
            return (double)total / (double)calificaciones.Length;
        }

        public static int[] encontrarCotas(int[] calificaciones)
        {
            int[] cotas = new int[2];
            for (int i = 0; i < calificaciones.Length; i++)
            {
                if (i == 0)
                {
                    cotas[0] = calificaciones[i];
                    cotas[1] = calificaciones[i];
                }
                else
                {
                    if (calificaciones[i] < cotas[0])
                    {
                        cotas[0] = calificaciones[i];
                    }
                    if (calificaciones[i] > cotas[1])
                    {
                        cotas[1] = calificaciones[i];
                    }
                }
            }
            return cotas;
        }

        public static void mostrarResumen(int[] cotas, double promedio)
        {
            Console.WriteLine("Nota menor: " + cotas[0]);
            Console.WriteLine("Nota mayor: " + cotas[1]);
            Console.WriteLine("Promedio: " + Math.Round(promedio, 2));
            Console.ReadKey();
        }

    }
}
