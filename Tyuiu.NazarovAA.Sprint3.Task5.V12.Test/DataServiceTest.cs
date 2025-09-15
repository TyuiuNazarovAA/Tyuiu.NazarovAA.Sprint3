using Tyuiu.NazarovAA.Sprint3.Task5.V12.Lib;

namespace Tyuiu.NazarovAA.Sprint3.Task5.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();
            double res = ds.GetSumSumSeries(5, 1, 1, 2, 2);
            double wait = 10.248;
            Assert.AreEqual(wait, res);
        }
    }
}
