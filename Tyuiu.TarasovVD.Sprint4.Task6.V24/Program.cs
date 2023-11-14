using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TarasovVD.Sprint4.Task6.V24.Lib;

namespace Tyuiu.TarasovVD.Sprint4.Task6.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Тарасов В. Д. | ПКТб-23-2 ";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #24                                                             *");
            Console.WriteLine("* Выполнил: Тарасов Владислав Денисович | ПКТб-23-2                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу на C# по заданным условиям.                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
            Console.WriteLine("***************************************************************************");
            var array = new string[]
            {
                "Компьютер",
                "Телефон",
                "Планшет",
                "Принтер",
                "Сканер",
                "Монитор",
                "Клавиатура"
            };
            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Элементы массива в которых больше 7 символов: ");

            var res = ds.Calculate(array);

            for (int i = 0; i < res.Length; i++)
            {
                Console.Write($"{res[i]} \t");
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
