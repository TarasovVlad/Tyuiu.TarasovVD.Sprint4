﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TarasovVD.Sprint4.Task4.V14.Lib;

namespace Tyuiu.TarasovVD.Sprint4.Task4.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            

            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.Write("Введите количество строк в массиве: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество столбцов в массиве: ");
            int columns = Convert.ToInt32(Console.ReadLine());
            int[,] mtrx = new int[rows, columns];
            Console.WriteLine("***************************************************************************");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j ++)
                {
                    Console.Write($"Введите {i}, {j} элемент массива: ");
                    mtrx[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("\nМассив: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{ mtrx[i, j] } \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            

            

            Console.WriteLine("\nМассив после замены: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{ ds.Calculate(mtrx)[i, j] } \t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
