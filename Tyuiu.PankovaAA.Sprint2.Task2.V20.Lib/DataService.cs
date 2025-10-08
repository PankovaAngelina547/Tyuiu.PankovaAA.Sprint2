using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.PankovaAA.Sprint2.Task2.V20.Lib
{
    public class DataService : ISprint2Task2V20
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;
            if (((x >= 1) && (x <= 3) && (y >= 1) && (y <= 13)) || ((x >= 3) && (x <= 13) && (y >= 6) && (y <= 8)))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}