using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KomarovaMV.Sprint0.Task6.V0.Lib;

namespace Tyuiu.KomarovaMV.Sprint0.Task6.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckAdditionArrayValid()
        {
            var nambers = new int [] { 1, 2, 3, 4, 5 };
            var res = DataService.AdditionArray(nambers);
            Assert.AreEqual(15, res);
        }
        public void CheckSubtractionArrayValid()
        {
            var nambers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.AdditionArray(nambers);
            Assert.AreEqual(-15, res);
        }
        public void CheckMultiplicationArrayValid()
        {
            var nambers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.AdditionArray(nambers);
            Assert.AreEqual(120, res);
        }

    }
}
