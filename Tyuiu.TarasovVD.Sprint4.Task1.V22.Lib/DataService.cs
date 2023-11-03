using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.TarasovVD.Sprint4.Task1.V22.Lib
{
    public class DataService : ISprint4Task1V22
    {
        public int Calculate(int[] array)
        {
            int product = 1;

            foreach (int element in array)
            {
                if (element % 2 != 0)
                {
                    product *= element;
                }
            }

            return product;
        }
    }
}
