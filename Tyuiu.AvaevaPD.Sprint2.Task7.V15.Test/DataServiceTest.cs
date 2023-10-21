using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.AvaeavPD.Sprint2.Task7.V15.Lib;
namespace Tyuiu.AvaevaPD.Sprint2.Task7.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            double x = 0.7;
            double y = 0.7;

            bool res = ds.CheckDotInShadedArea(x, y);

            bool wait = true;

            Assert.AreEqual(wait, res);


        }
    }
}
