using Tyuiu.PankovaAA.Sprint2.Task3.V11.Lib;
namespace Tyuiu.PankovaAA.Sprint2.Task3.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 2;
            double wait = 2 + System.Math.Pow((2 - 15) / (2 - 19), 2);
            wait = System.Math.Round(wait, 3);
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 0;
            double numerator = 0 - System.Math.Cos(0) + 10;
            double denominator = 0 - System.Math.Sin(0) + 12;
            double wait = System.Math.Round(numerator / denominator, 3);
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            double x = -5;
            double wait = System.Math.Pow(1 + 1 / System.Math.Pow(-5, 2), 2);
            wait = System.Math.Round(wait, 3);
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition4()
        {
            DataService ds = new DataService();
            double x = -20;
            double wait = -20 + 10 * (-20) - (1 / (-20));
            wait = System.Math.Round(wait, 3);
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition5()
        {
            DataService ds = new DataService();
            double x = 10;
            double wait = 10 + System.Math.Pow((10 - 15) / (10 - 19), 2);
            wait = System.Math.Round(wait, 3);
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}