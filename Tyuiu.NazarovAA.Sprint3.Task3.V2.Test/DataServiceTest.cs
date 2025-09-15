using Tyuiu.NazarovAA.Sprint3.Task3.V2.Lib;

namespace Tyuiu.NazarovAA.Sprint3.Task3.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMaxCharCount()
        {
            DataService ds = new DataService();
            int res = ds.GetMaxCharCount("asdzzz vfvfzz v gthvz", 'z');
            int wait = 3;
            Assert.AreEqual(wait, res);
        }
    }
}
