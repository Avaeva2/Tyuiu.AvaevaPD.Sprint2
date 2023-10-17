using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.AvaevaPD.Sprint2.Task0.V0.Lib;
namespace Tyuiu.AvaevaPD.Sprint2.Task0.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()

        {
            DataService ds = new DataService();
            int x = 95;
            int y = 1735;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            bool[] wait = new bool[6] { true, false, true, false, true, false };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
