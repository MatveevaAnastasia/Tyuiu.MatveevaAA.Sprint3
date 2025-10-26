using Tyuiu.MatveevaAA.Sprint3.Task0.V20.Lib;

namespace Tyuiu.MatveevaAA.Sprint3.Task0.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            var ds = new DataService();
            double actual = ds.GetMultiplySeries(1,1, 14);

            // точное значение ~ 287.1801379248
            double expected = 287.180138;
            Assert.AreEqual(expected, actual, 1e-6);
        }
    }
}
  