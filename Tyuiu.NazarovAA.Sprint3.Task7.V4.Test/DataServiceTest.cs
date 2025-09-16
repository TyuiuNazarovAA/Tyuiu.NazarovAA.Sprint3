using Tyuiu.NazarovAA.Sprint3.Task7.V4.Lib;

namespace Tyuiu.NazarovAA.Sprint3.Task7.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            double[] resMas = ds.GetMassFunction(-2, 2);
            double[] waitMas =
            {
                -3.83,
                -11.7,
                3,
                2.19,
                3.31
            };
            CollectionAssert.AreEqual(waitMas, resMas);
        }
    }
}
