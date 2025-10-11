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
            double y = 7;
            double res = ds.Calculate(x, y);
            double wait = 25;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 15;
            double y = 10;
            double res = ds.Calculate(x, y);
            double wait = 0.107;
            Assert.AreEqual(wait, res);
        }
    }
}
