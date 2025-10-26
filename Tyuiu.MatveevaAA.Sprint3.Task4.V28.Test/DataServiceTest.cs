using Tyuiu.MatveevaAA.Sprint3.Task4.V28.Lib;

namespace Tyuiu.MatveevaAA.Sprint3.Task4.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double y = 8.995;
            Assert.AreEqual(y, ds.Calculate(-5, 5));
        }
    }
}
