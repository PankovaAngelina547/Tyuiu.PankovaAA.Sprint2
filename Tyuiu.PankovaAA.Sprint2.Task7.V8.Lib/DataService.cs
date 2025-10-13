using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.PankovaAA.Sprint2.Task7.V8.Lib
{
    public class DataService : ISprint2Task7V8
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if (x >= -2 && x <= 3 && y >= x && y <= 4)
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
