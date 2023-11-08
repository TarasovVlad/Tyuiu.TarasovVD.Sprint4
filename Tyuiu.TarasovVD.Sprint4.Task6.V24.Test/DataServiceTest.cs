using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TarasovVD.Sprint4.Task6.V24.Lib;

namespace Tyuiu.TarasovVD.Sprint4.Task6.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string[] array = new string[]
        {
            "Компьютер",
            "Телефон",
            "Планшет",
            "Принтер",
            "Сканер",
            "Монитор",
            "Клавиатура"
        };

            string[] wait = new string[]
            {
            "Компьютер",
            "Клавиатура"
            };

           
            string[] res = ds.Calculate(array);

            
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
