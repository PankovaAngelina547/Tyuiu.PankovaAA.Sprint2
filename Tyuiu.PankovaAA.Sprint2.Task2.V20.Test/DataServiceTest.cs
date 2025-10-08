using Tyuiu.PankovaAA.Sprint2.Task2.V20.Lib;
namespace Tyuiu.PankovaAA.Sprint2.Task2.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            int x = 0;
            int y = 0;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = false;

            Assert.AreEqual(wait, res);
        }
    }
}
