using Tyuiu.MatveevaAA.Sprint3.Task1.V21.Lib;

namespace Tyuiu.MatveevaAA.Sprint3.Task1.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            var ds = new DataService();
            double actual = ds.GetMultiplySeries(1, 1, 12);
            double expected = 16947810.880588; // рассчитанное значение
            Assert.AreEqual(expected, actual, 1e-6);
        }
    }
}
