using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.PankovaAA.Sprint2.Task5.V12.Lib
{
    public class DataService : ISprint2Task5V12
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            if (g <= 0 || m <= 0 || m > 12 || n <= 0)
                throw new ArgumentException("Некорректные входные данные");
            if (n > GetDaysInMonth(g, m))
                throw new ArgumentException("Некорректный день для данного месяца");
            if (n > 1)
            {
                return $"{n - 1:D2}.{m:D2}.{g}";
            }

            int prevDay, prevMonth, prevYear;

            switch (m)
            {
                case 1:
                    prevDay = 31;
                    prevMonth = 12;
                    prevYear = g - 1;
                    break;
                case 2:
                    prevDay = 31;
                    prevMonth = 1;
                    prevYear = g;
                    break;
                case 3:
                    prevDay = IsLeapYear(g) ? 29 : 28;
                    prevMonth = 2;
                    prevYear = g;
                    break;
                case 4:
                    prevDay = 31;
                    prevMonth = 3;
                    prevYear = g;
                    break;
                case 5:
                    prevDay = 30;
                    prevMonth = 4;
                    prevYear = g;
                    break;
                case 6:
                    prevDay = 31;
                    prevMonth = 5;
                    prevYear = g;
                    break;
                case 7:
                    prevDay = 30;
                    prevMonth = 6;
                    prevYear = g;
                    break;
                case 8:
                    prevDay = 31;
                    prevMonth = 7;
                    prevYear = g;
                    break;
                case 9:
                    prevDay = 31;
                    prevMonth = 8;
                    prevYear = g;
                    break;
                case 10:
                    prevDay = 30;
                    prevMonth = 9;
                    prevYear = g;
                    break;
                case 11:
                    prevDay = 31;
                    prevMonth = 10;
                    prevYear = g;
                    break;
                case 12:
                    prevDay = 30;
                    prevMonth = 11;
                    prevYear = g;
                    break;
                default:
                    throw new ArgumentException("Некорректный номер месяца");
            }

            
            return $"{prevDay:D2}.{prevMonth:D2}.{prevYear}";
        }

        
        private int GetDaysInMonth(int year, int month)
        {
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                case 2:
                    return IsLeapYear(year) ? 29 : 28;
                default:
                    throw new ArgumentException("Некорректный номер месяца");
            }
        }

        private bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }
    }
}
