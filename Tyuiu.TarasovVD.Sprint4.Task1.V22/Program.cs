using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TarasovVD.Sprint4.Task1.V22.Lib;

namespace Tyuiu.TarasovVD.Sprint4.Task1.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
            Console.WriteLine("***************************************************************************");
            int[] array = { 8, 5, 4, 4, 3, 9, 9, 9, 3, 4, 4, 9 };
            Console.WriteLine("Дан массив: { 8, 5, 4, 4, 3, 9, 9, 9, 3, 4, 4, 9 }");
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int sum = ds.Calculate(array);
            Console.WriteLine("Произведение нечетных элементов: " + sum);
            Console.ReadKey();
        }
    }
}
