using Tyuiu.NazarovAA.Sprint3.Task0.V1.Lib;

namespace Tyuiu.NazarovAA.Sprint3.Task0.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            double res = ds.GetSumSeries(4, 1, 2);
            double wait = 50;
            Assert.AreEqual(wait, res);
        }
    }
}
