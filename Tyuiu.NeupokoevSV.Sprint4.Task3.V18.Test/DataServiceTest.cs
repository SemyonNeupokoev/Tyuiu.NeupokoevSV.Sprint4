using Tyuiu.NeupokoevSV.Sprint4.Task3.V18.Lib;
namespace Tyuiu.NeupokoevSV.Sprint4.Task3.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] data = new int[5, 5] { { 2, 4, 2, 7, 7, }, { 4, 7, 9, 9, 7 }, { 8, 5, 5, 6, 5 }, { 7, 7, 5, 2, 9 }, { 9, 3, 7, 9, 8 } };
            int res = ds.Calculate(data);
            Assert.AreEqual(9, res);
        }
    }
}
