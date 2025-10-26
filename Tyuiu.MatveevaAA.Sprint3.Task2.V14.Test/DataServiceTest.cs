
using Tyuiu.MatveevaAA.Sprint3.Task2.V14.Lib;

namespace Tyuiu.MatveevaAA.Sprint3.Task2.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            double actual = ds.GetMultiplySeries(5, 1, 6);
            double expected = 0.000097845;           // 0.04608^3 = 9.7844723712e-05
            Assert.AreEqual(expected, actual, 1e-9);

        }
    }
}
