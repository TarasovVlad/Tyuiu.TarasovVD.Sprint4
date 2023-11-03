using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TarasovVD.Sprint4.Task3.V15.Lib;

namespace Tyuiu.TarasovVD.Sprint4.Task3.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mas2 = new int[5, 5]{    {7, 4, 2, 5, 3},
                                            {4, 3, 2, 5, 6},
                                            {6, 3, 4, 7, 5},
                                            {5, 7, 4, 3, 8},
                                            {7, 8, 8, 5, 6} };
            int rowCount = mas2.GetLength(0);
            int colCount = mas2.GetLength(1);
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Массив:");
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                {
                    Console.Write($"{mas2[i, j]} \t");
                }

                Console.WriteLine();
            }       
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(mas2);
            Console.WriteLine("Количество нечетных элементов в массиве: " + res);
            Console.ReadKey();
        }
    }
}
