using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.PankovaAA.Sprint2.Task7.V8.Lib
{
    public class DataService : ISprint2Task7V8
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            if(x >= -2 && x <= 3)
            {
                if (y >= 1 && y <= 4)
                {
                    return true;
                }

                if (x <= 1 && y >= x && y <= 1)
                {
                    return true;
                }
            }

            return false;
        }
    }
}








