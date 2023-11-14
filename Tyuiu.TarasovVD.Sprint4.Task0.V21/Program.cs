using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TarasovVD.Sprint4.Task0.V21.Lib;

namespace Tyuiu.TarasovVD.Sprint4.Task0.V21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Тарасов В. Д. | ПКТб-23-2 ";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнил: Тарасов Владислав Денисович | ПКТб-23-2                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу на C# по заданным условиям.                          *");
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
            Console.WriteLine("***************************************************************************");
            int[] array = { 8, 2, 4, 3, 8, 5, 6, 7, 9, 8 };
            Console.WriteLine("Дан массив: { 8, 2, 4, 3, 8, 5, 6, 7, 9, 8 }");
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int sum = ds.GetSumEvenArrEl(array);
            Console.WriteLine("Сумма четных элементов: " + sum);





            Console.ReadKey();
        }
    }
}
