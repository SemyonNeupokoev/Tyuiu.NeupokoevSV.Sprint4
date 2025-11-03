using Tyuiu.NeupokoevSV.Sprint4.Task6.V5.Lib;

namespace Tyuiu.NeupokoevSV.Sprint4.Task6.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string[] a = { "Меркурий", "Венера", "Земля", "Марс", "Юпитер", "Сатурн", "Уран", "Нептун"};
            int res = ds.Calculate(a);
            Assert.AreEqual(1, res);
        }
    }
}
