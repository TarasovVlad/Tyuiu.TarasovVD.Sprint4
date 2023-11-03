using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TarasovVD.Sprint4.Task2.V20.Lib;

namespace Tyuiu.TarasovVD.Sprint4.Task2.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = { 3, 5, 4, 7, 6, 2, 3, 4, 5, 6, 7, 3, 2, 7, 4, 6 };
            int expectedSum = 34; 

            int actualSum = ds.Calculate(array);

            Assert.AreEqual(expectedSum, actualSum);
        }
    }
}
