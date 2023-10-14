using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KondrakovAA.Sprint1.Task5.V1.Lib;

namespace Tyuiu.KondrakovAA.Sprint1.Task5.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService resp = new DataService();
            Assert.AreEqual(resp.DistanceBetweenDots(4,4,1,0), 5);
        }
    }
}
