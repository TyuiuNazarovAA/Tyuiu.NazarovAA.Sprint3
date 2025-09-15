using Tyuiu.NazarovAA.Sprint3.Task6.V17.Lib;

namespace Tyuiu.NazarovAA.Sprint3.Task6.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();
            int res = ds.GetSumTheDivisors(1, 3);
            int wait = 5;
            Assert.AreEqual(wait, res);
        }
    }
}
