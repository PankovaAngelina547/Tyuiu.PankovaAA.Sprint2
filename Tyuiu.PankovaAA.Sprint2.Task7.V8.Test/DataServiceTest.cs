using Tyuiu.PankovaAA.Sprint2.Task7.V8.Lib;
namespace Tyuiu.PankovaAA.Sprint2.Task7.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 3;

            bool res = ds.CheckDotInShadedArea(x,y);
            bool wait = true;
            Assert.AreEqual(wait,res);

        }
    }
}
