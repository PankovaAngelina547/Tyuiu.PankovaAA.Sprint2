using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.PankovaAA.Sprint2.Task4.V28.Lib
{
    public class DataService : ISprint2Task4V28
    {
        public double Calculate(double x, double y)
        {
            double z = 1.0;

            double result = (x < y * 2 - 10)
                ? Math.Pow(1 + (y + z) / x, x)
                : (Math.Pow(z, 2) - Math.Pow(1 / Math.Cos(y), 2) + 12) /
                  (Math.Pow(y, 2) - Math.Pow(Math.Sin(x), 2) + 9);

            return Math.Round(result, 3);
        }
    }
}
