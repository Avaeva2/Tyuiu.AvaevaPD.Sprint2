using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AvaevaPD.Sprint2.Task4.V15.Lib;
namespace Tyuiu.AvaevaPD.Sprint2.Task4.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 25;
            double y = 36;
            double res = ds.Calculate(x, y);
            double wait = 9.0;
            Assert.AreEqual(wait, res);



        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 36;
            double y = 81;
            double res = ds.Calculate(x, y);
            double wait = 9.0;
            Assert.AreEqual(wait, res);



        }




    }


}
