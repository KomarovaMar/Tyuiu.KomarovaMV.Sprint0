﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KomarovaMV.Sprint0.Task5.V0.Lib;

namespace Tyuiu.KomarovaMV.Sprint0.Task5.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        
        
            public void CheckedAdditionValid()
            {
                Assert.AreEqual(10, DataService.Addition(5, 5));
            }
            public void CheckedSubtractionValid()
            {
                Assert.AreEqual(5, DataService.Addition(10, 5));
            }
            public void CheckedMultiplicationValid()
            {
                Assert.AreEqual(50, DataService.Addition(10, 5));
            }
            public void CheckedDivisionValid()
            {
                Assert.AreEqual(3, DataService.Addition(9, 3));
            }
        
    }
}
