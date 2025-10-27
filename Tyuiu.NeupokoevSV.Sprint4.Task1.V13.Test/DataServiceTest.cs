using Tyuiu.NeupokoevSV.Sprint4.Task1.V13.Lib;
namespace Tyuiu.NeupokoevSV.Sprint4.Task1.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] a = { 8, 1, 5, 4, 2, 1, 2, 7, 6, 1 };
            int res = ds.Calculate(a);
            Assert.AreEqual(22, res);

        }
    }
}
