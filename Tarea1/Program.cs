﻿using System;
using Tarea1;

namespace tarea1
{
    class Program : Universidad
    {
        public static void Main(string[] args)
        {
            Universidad universidad = new Universidad();
            Console.WriteLine("Ingrese el nombre del estudiante:");
            Universidad.Estudiante.Nombre = Console.ReadLine();

            Console.WriteLine($"Ingrese el numero de sesiones totales del curso de: {Universidad.Estudiante.Nombre}");
            Universidad.Estudiante.SesionesT = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Ingrese el numero de asistencias de: {Universidad.Estudiante.Nombre}");
            Universidad.Estudiante.SesionesA = Convert.ToInt32(Console.ReadLine());

            
            Universidad.Estudiante.Asistencia.PrintMetodo();
        }
    }
}