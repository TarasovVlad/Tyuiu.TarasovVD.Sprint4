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
            int sum = ds.GetSumOddArrEl(array);
            Console.WriteLine("Сумма четных элементов: " + sum);





            Console.ReadKey();
        }
    }
}
