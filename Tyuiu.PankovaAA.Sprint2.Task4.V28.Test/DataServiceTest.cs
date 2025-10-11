using Tyuiu.PankovaAA.Sprint2.Task4.V28.Lib;
namespace Tyuiu.PankovaAA.Sprint2.Task4.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidConditionFirstBranch()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 5;
            double result = ds.Calculate(x, y);
            double expected = 8.0;
            Assert.AreEqual(expected, result, 0.001);
        }

        [TestMethod]
        public void ValidConditionSecondBranch()
        {
            DataService ds = new DataService();
            double x = 15;
            double y = 5;
            double result = ds.Calculate(x, y);
            double expected = 450.133;
            Assert.AreEqual(expected, result, 0.001);
        }
    }
}
