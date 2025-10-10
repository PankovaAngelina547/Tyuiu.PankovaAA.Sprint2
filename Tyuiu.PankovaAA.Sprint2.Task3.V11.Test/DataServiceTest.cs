using Tyuiu.PankovaAA.Sprint2.Task3.V11.Lib;
namespace Tyuiu.PankovaAA.Sprint2.Task3.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 10;
            double res = ds.Calculate(x);
            double wait = 10.694;  
            Assert.AreEqual(10.309, res, 0.001);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = 0.833;  
            Assert.AreEqual(0.75, res, 0.001);
        }

        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            double x = -5;
            double res = ds.Calculate(x);
            double wait = 1.082; 
            Assert.AreEqual(1.082, res, 0.001);
        }

        [TestMethod]
        public void ValidCondition4()
        {
            DataService ds = new DataService();
            double x = -20;
            double res = ds.Calculate(x);
            double wait = -219.95;  
            Assert.AreEqual(-219.95, res, 0.001);
        }
    }
    
}
