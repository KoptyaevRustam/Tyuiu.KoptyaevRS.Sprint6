using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KoptyaevRS.Sprint6.Task7.V15.Lib;

namespace Tyuiu.KoptyaevRS.Sprint6.Task7.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Valid()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[2, 8] { { 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, -3, 0 } };
            int[,] res = ds.GetMatrix(matrix);
            int[,] wait = new int[2, 8] { { 0, 0, 0, 0, 0, 0, 3, 0 }, { 0, 0, 0, 0, 0, 0, 3, 0 } };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
