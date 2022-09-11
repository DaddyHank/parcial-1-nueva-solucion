using System;
using System.Collections;

namespace parcial_1
{
    class Program
    {
        private static string Nombre;
        private static int Edad;
        private static double Promedio;

        static void Main(string[] args)
        {
            string condicion = "si";
            do
            {
                int Estudiantes;
                ArrayList registro = new ArrayList();
                string nombre;
                int edad;
                double lab1;
                double lab2;
                double parcial;
                double promedio;
                int contador = 0;

                Console.WriteLine("Ingrese el número de estudiantes a procesar: ");
                Estudiantes = int.Parse(Console.ReadLine());

                while (contador < Estudiantes)
                {
                    Console.WriteLine("Ingrese el nombre del estudiante: ");
                    nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese la edad del estudiante: ");
                    edad = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la nota del laboratorio 1: ");
                    lab1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la nota del laboratorio 2: ");
                    lab2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la nota del parcial: ");
                    parcial = double.Parse(Console.ReadLine());
                    promedio = (lab1 * 0.3) + (lab2 * 0.3) + (parcial * 0.4);

                    _Estudiantes estudiante = new _Estudiantes(Nombre = nombre, Edad = edad, Promedio = promedio);
                    registro.Add(estudiante);

                    contador++;

                    if (promedio >= 6)
                    {
                        Console.WriteLine("Aprobado");
                    }
                    else
                    {
                        Console.WriteLine("Reprobado");
                    }
                }

                foreach (_Estudiantes st in registro)
                {
                    Console.WriteLine(st.getData());
                }

                Console.WriteLine("Si desea continuar ingresando datos digite 'si', sino, presione cualquier tecla");
                condicion = Console.ReadLine();
            } while (condicion == "si");
        }
    }
}
