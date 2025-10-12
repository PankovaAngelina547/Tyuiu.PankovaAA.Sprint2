using Tyuiu.PankovaAA.Sprint2.Task5.V12.Lib;
namespace Tyuiu.PankovaAA.Sprint2.Task5.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidTest1()
        {
            DataService ds = new DataService();

            int g = 2024;
            int m = 3;
            int n = 15;

            string expected = "14.03.2024";
            string actual = ds.FindDateOfPreviousDay(g, m, n);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidTest2()
        {
            DataService ds = new DataService();

            int g = 2024;
            int m = 5;
            int n = 1;

            string expected = "30.04.2024";
            string actual = ds.FindDateOfPreviousDay(g, m, n);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidTest3()
        {
            DataService ds = new DataService();

            int g = 2024;
            int m = 3;
            int n = 1;

            string expected = "29.02.2024";
            string actual = ds.FindDateOfPreviousDay(g, m, n);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidTest1()
        {
            DataService ds = new DataService();

            int g = 2024;
            int m = 2;
            int n = 30;

            ds.FindDateOfPreviousDay(g, m, n);
        }
    }
}
            
        