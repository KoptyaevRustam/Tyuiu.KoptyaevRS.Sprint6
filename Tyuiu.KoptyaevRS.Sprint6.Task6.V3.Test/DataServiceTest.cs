using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KoptyaevRS.Sprint6.Task6.V3.Lib;

namespace Tyuiu.KoptyaevRS.Sprint6.Task6.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var path = @"C:\DataSprint6\InPutFileTask6V3.txt";
            string str = "r";
            var res = ds.CollectTextFromFile(str, path);
            string wait = " rdRibhX swrfhvUjC raHsMtQF jiUFMDjMsEervIz";
            Assert.AreEqual(wait, res);
        }
    }
}
