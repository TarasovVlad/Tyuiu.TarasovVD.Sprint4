using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TarasovVD.Sprint4.Task0.V21.Lib;

namespace Tyuiu.TarasovVD.Sprint4.Task0.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumOddArrEl()
        {
            DataService ds = new DataService();
            int[] numsArray = { 8, 2, 4, 3, 8, 5, 6, 7, 9, 8 };
            int res = ds.GetSumOddArrEl(numsArray);
            int numsWaitArray = 36;
            Assert.AreEqual(numsWaitArray, res);
        }
    }
}
