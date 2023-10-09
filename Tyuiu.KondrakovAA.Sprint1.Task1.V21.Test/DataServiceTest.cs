using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KondrakovAA.Sprint1.Task1.V21.Lib;

namespace Tyuiu.KondrakovAA.Sprint1.Task1.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService r = new DataService();
            Assert.AreEqual(1, r.Calc(2, 3));
        }
    }
}
