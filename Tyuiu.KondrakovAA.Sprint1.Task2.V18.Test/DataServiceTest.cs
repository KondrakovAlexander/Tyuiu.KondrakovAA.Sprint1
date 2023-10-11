using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KondrakovAA.Sprint1.Task2.V18.Lib;

namespace Tyuiu.KondrakovAA.Sprint1.Task2.V18.Test
{
    [TestClass]
    public class DataServiceTest { 
        [TestMethod]
        public void TestMethod1()
        {
        DataService resp = new DataService();
            Assert.AreEqual(76, resp.CalculateSideSquareParallelepiped(2,4,5));
        }
    }
}
