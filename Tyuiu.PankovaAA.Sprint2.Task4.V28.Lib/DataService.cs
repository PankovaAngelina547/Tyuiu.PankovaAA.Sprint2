using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.PankovaAA.Sprint2.Task4.V28.Lib
{
    public class DataService : ISprint2Task4V28
    {
        public double Calculate(double x, double y)
        {
            return (x < y * 2 - 10)
       ? Math.Round(Math.Pow(1 + (y - 2) / (x * x), x), 3)
       : Math.Round((2 * x * x - Math.Cos(y * y) + 12) / (y * y - Math.Sin(x) + 8.19), 3);
        }
    }
}