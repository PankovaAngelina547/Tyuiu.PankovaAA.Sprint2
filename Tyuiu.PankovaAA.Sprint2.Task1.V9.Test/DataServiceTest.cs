using Tyuiu.PankovaAA.Sprint2.Task1.V9.Lib;
namespace Tyuiu.PankovaAA.Sprint2.Task1.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetLogicOperations()
        {
            DataService ds = new DataService();
            int a =15;
            int b =335;
            int c =174;
            int d =478;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);
            bool[] wait = new bool[6] {false,false,true,false,true,false};
            CollectionAssert.AreEqual(wait,res);
        }
    }
}
