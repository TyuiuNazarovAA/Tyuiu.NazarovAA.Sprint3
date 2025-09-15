using Tyuiu.NazarovAA.Sprint3.Task2.V24.Lib;

namespace Tyuiu.NazarovAA.Sprint3.Task2.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            double res = ds.GetMultiplySeries(0.25, 1, 2);
            double wait = 16.209;
            Assert.AreEqual(wait, res);
        }
    }
}
