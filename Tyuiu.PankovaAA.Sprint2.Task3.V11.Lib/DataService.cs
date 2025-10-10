using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.PankovaAA.Sprint2.Task3.V11.Lib
{
    public class DataService : ISprint2Task3V11
    {
        public double Calculate(double x)
        {
            double y = 0;
            if (x > 0)
            {
                // x + ((x - 15)/(x - 19))^x
                double fraction = (x - 15) / (x - 19);
                y = x + Math.Pow(fraction, x);
            }
            else if (x == 0)
            {
                // (x² - cos(x²) + 10) / (x² - sin(x²) + 12)
                double xSquared = x * x;
                double numerator = xSquared - Math.Cos(xSquared) + 10;
                double denominator = xSquared - Math.Sin(xSquared) + 12;
                y = numerator / denominator;
            }
            else if (x > -15 && x < 0)
            {
                // (1 + 1/x²)^2
                double innerExpression = 1 + 1 / (x * x);
                y = Math.Pow(innerExpression, 2);
            }
            else if (x < -15)
            {
                // x + 10x - (1/x)
                y = x + 10 * x - (1 / x);
            }

            return Math.Round(y, 3);
        }
    }
}



