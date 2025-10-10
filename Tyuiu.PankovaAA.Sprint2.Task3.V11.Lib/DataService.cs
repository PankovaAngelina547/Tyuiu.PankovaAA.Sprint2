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
                if (Math.Abs(x - 19) < 1e-10)
                    throw new ArgumentException("Ошибка: деление на ноль при x = 19");

                double fraction = (x - 15) / (x - 19);
                y = x + Math.Pow(fraction, 2);
            }
            else if (x == 0)
            {
                double xSquared = x * x;
                double numerator = xSquared - Math.Cos(xSquared) + 10;
                double denominator = xSquared - Math.Sin(xSquared) + 12;

                if (Math.Abs(denominator) < 1e-10)
                    throw new ArgumentException("Ошибка: деление на ноль при x = 0");

                y = numerator / denominator;
            }
            else if (x > -15 && x < 0)
            {
                if (Math.Abs(x) < 1e-10)
                    throw new ArgumentException("Ошибка: деление на ноль при x = 0");

                double innerExpression = 1 + 1 / (x * x);
                y = Math.Pow(innerExpression, 2);
            }
            else // x < -15
            {
                if (Math.Abs(x) < 1e-10)
                    throw new ArgumentException("Ошибка: деление на ноль при x = 0");

                // Исправлено: x + 10x - (1/x) = 11x - 1/x
                y = 11 * x - (1 / x);
            }

            return Math.Round(y, 3);
        }
    }
}
    
    

