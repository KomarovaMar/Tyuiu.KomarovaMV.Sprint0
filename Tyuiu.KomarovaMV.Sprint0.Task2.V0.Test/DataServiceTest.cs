using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


using Tyuiu.KomarovaMV.Sprint0.Task2.V0.Lib;
namespace Tyuiu.KomarovaMV.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Маргарита";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет,Маргарита", res);
        }
        }
    }

