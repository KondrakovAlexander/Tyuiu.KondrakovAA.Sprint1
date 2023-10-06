using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KondrakovAA.Sprint1.Task0.V0.Lib;

namespace Tyuiu.KondrakovAA.Sprint1.Task0.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalc()
        {
            int res = DataService.Calc();
            Assert.AreEqual(3, res);
        }
    }
}
