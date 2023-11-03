using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.TarasovVD.Sprint4.Task3.V15.Lib
{
    public class DataService : ISprint4Task3V15
    {
        public int Calculate(int[,] array)
        {
            int rowCount = array.GetLength(0);
            int colCount = array.GetLength(1);
            int oddCount = 0;

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                {
                    if (array[i, j] % 2 != 0)
                    {
                        oddCount++;
                    }
                }
            }

            return oddCount;
        }
    }
}
