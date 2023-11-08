﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TarasovVD.Sprint4.Task4.V14.Lib;

namespace Tyuiu.TarasovVD.Sprint4.Task4.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[5, 5] {
            {1, 3, 7, 7, 6},
            {4, 2, 6, 3, 3},
            {4, 5, 1, 4, 6},
            {7, 5, 2, 7, 7},
            {2, 4, 4, 4, 7}
        };
            int[,] res = ds.Calculate(matrix);
            int[,] wait = new int[5, 5] {
            {0, 0, 0, 0, 6},
            {4, 2, 6, 0, 0},
            {4, 0, 0, 4, 6},
            {0, 0, 2, 0, 0},
            {2, 4, 4, 4, 0}
        };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
