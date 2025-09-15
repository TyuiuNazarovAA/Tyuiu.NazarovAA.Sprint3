using Tyuiu.NazarovAA.Sprint3.Task1.V11.Lib;

namespace Tyuiu.NazarovAA.Sprint3.Task1.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            double res = ds.GetMultiplySeries(0.75, 1, 2);
            double wait = 1.328;
            Assert.AreEqual(wait, res);
        }
    }
}
