using Tyuiu.NeupokoevSV.Sprint4.Task7.V7.Lib;
namespace Tyuiu.NeupokoevSV.Sprint4.Task7.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string a = "31415926";
            int n = 4;
            int m = 2;
            int res = ds.Calculate(n, m, a);
            Assert.AreEqual(5, res);
        }
    }
}
