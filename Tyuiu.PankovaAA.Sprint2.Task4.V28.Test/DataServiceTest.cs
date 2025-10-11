using Tyuiu.PankovaAA.Sprint2.Task4.V28.Lib;
namespace Tyuiu.PankovaAA.Sprint2.Task4.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()

        {
            DataService ds = new DataService();
            double x = 2;
            double y = 10;
            double res = ds.Calculate(x, y);
            double wait = 16;
            Assert.AreEqual(wait, res, 0.001);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 15;
            double y = 10;
            double result = ds.Calculate(x, y);
            double expected = 4.249;
            Assert.AreEqual(expected, result, 0.001);
        }
    }
}
