using Tyuiu.NazarovAA.Sprint3.Task4.V1.Lib;

namespace Tyuiu.NazarovAA.Sprint3.Task4.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(-2, 2);
            double wait = 1.296;
            Assert.AreEqual(wait, res);
        }
    }
}
