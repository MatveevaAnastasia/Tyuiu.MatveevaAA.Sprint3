using Tyuiu.MatveevaAA.Sprint3.Task3.V22.Lib;

namespace Tyuiu.MatveevaAA.Sprint3.Task3.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMaxCharCount()
        {

        DataService ds = new DataService();
        int max = 4;
        Assert.AreEqual(max, ds.GetMaxCharCount("fyyklbtyn ygrc vfyyyyh", 'y'));

        }
    }
}
