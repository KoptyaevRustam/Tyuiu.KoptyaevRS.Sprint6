using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KoptyaevRS.Sprint6.TaskReview.V30.Lib;

namespace Tyuiu.KoptyaevRS.Sprint6.TaskReview.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            DataService ds = new DataService();

            int c = 1;
            int k = 0;
            int l = 3;

            int[,] array = new int[4, 4]
            {
                {6,8,9,4},
                {-2,1,7,3},
                {8,7,3,1},
                {2,-6,9,-3}
            };
            double res = ds.GetResult(array, c, k, l);
            double wait = 2;
            Assert.AreEqual(wait, res);
        }
    }
}
