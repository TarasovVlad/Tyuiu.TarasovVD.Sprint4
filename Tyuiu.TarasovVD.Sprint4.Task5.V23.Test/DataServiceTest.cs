using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TarasovVD.Sprint4.Task5.V23.Lib;

namespace Tyuiu.TarasovVD.Sprint4.Task5.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[5, 5] {
            {2, -1, 4, 0, -3},
            {7, -4, 8, -2, -1},
            {-4, 6, -3, 1, 5},
            {0, 3, -4, 2, 8},
            {6, -1, 7, -3, 0}
        };
            int[,] res = ds.Calculate(matrix);
            int[,] wait = new int[5, 5] {
            {2, 0, 4, 0, 0},
            {7, 0, 8, 0, 0},
            {0, 6, 0, 1, 5},
            {0, 3, 0, 2, 8},
            {6, 0, 7, 0, 0}
        };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
