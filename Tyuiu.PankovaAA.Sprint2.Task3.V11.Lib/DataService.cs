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
                // Для x > 0: x + ((x - 15)/(x - 19))^2
                if (Math.Abs(x - 19) < 1e-10) // Проверка деления на ноль
                    throw new ArgumentException("Ошибка: деление на ноль при x = 19");

                double fraction = (x - 15) / (x - 19);
              y=x+ Math.Pow(fraction, 2);
            }
            else if (x == 0)
            {
                // Для x = 0: (x^2 - cos(x^2) + 10) / (x^2 - sin(x^2) + 12)
                double xSquared = x * x;
                double numerator = xSquared - Math.Cos(xSquared) + 10;
                double denominator = xSquared - Math.Sin(xSquared) + 12;

                if (Math.Abs(denominator) < 1e-10) // Проверка деления на ноль
                    throw new ArgumentException("Ошибка: деление на ноль при x = 0");

                y= numerator / denominator;
            }
            else if (x > -15 && x < 0)
            {
                // Для -15 < x < 0: (1 + 1/x^2)^2
                if (Math.Abs(x) < 1e-10) // Проверка деления на ноль
                    throw new ArgumentException("Ошибка: деление на ноль при x = 0");

                double innerExpression = 1 + 1 / (x * x);
                y=Math.Pow(innerExpression, 2);
            }
            else // x < -15
            {
                // Для x < -15: x + 10x - (1/x)
                if (Math.Abs(x) < 1e-10) // Проверка деления на ноль
                    throw new ArgumentException("Ошибка: деление на ноль при x = 0");

                y = 10 * x - (1 / x);
            }

            // Округление до 3 знаков после запятой
            return Math.Round(y, 3);
        }
    }
    
}
