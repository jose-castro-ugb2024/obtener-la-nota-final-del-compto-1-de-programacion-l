﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obtener_la_nota_final_del_compto_1_de_programacion_l
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ejercicio de obtener la nota final de la materia de Programacion I.
            Console.WriteLine("Lab1: ");
            double lab1 = double.Parse(Console.ReadLine());//8

            Console.WriteLine("Lab2: ");
            double lab2 = double.Parse(Console.ReadLine());//9

            Console.WriteLine("Parcial1: ");
            double parcial1 = double.Parse(Console.ReadLine());//7
            // 8*30%= 2.4
            // 9*30%= 2.7
            // 7*40%= 2.8
            // C1   = 7.9


            double c1 = lab1 * 30 / 100 + lab2 * 30 / 100 + parcial1 * 40 / 100;
            Console.WriteLine("La nota del Computo 1 es: {0}", c1);
            //Pausa
            Console.ReadLine();
        }
    }
}
