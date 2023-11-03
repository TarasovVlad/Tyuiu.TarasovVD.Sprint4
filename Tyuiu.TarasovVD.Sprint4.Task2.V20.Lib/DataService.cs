using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.TarasovVD.Sprint4.Task2.V20.Lib
{
    public class DataService : ISprint4Task2V20
    {
        public int Calculate(int[] array)
        {
            int sum = 0;

            foreach (int element in array)
            {
                if (element % 2 == 0)
                {
                    sum += element;
                }
            }

            return sum;
        }
    }
}
