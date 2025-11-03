using Tyuiu.NeupokoevSV.Sprint4.Task5.V30.Lib;
namespace Tyuiu.NeupokoevSV.Sprint4.Task5.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] data = new int[5, 5] { { 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1 } };
            int res = ds.Calculate(data);
            Assert.AreEqual(25, res);
        }
    }
}
