using Tyuiu.PankovaAA.Sprint2.Task4.V28.Lib;
namespace Tyuiu.PankovaAA.Sprint2.Task4.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculateFirstCondition()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 10;
            double res = ds.Calculate(x, y);
            double wait = 16;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void CheckCalculateSecondCondition()
        {
            DataService ds = new DataService();
            double x = 15;
            double y = 5;
            double res = ds.Calculate(x, y);
            double wait = 450.133;
            Assert.AreEqual(wait, res);
        }
    }
}
