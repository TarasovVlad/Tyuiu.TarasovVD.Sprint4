using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.TarasovVD.Sprint4.Task6.V24.Lib
{
    public class DataService : ISprint4Task6V24
    {
        public string[] Calculate(string[] array)
        {
            var res = new List<string>();
            foreach (var item in array)
            {
                if (item.Length > 7)
                {
                    res.Add(item);
                }
            }

            return res.ToArray();
        }
    }
}
