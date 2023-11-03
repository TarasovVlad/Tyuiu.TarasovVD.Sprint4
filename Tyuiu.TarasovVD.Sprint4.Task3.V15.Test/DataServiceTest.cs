using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TarasovVD.Sprint4.Task3.V15.Lib;

namespace Tyuiu.TarasovVD.Sprint4.Task3.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] mas2 = new int[5, 5]{    {7, 4, 2, 5, 3},
                                            {4, 3, 2, 5, 6},
                                            {6, 3, 4, 7, 5},
                                            {5, 7, 4, 3, 8},
                                            {7, 8, 8, 5, 6} };
            int res = ds.Calculate(mas2);
            int wait = 13;
            Assert.AreEqual(wait, res);
        }



    }
}
