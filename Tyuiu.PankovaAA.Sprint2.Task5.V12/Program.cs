using Tyuiu.PankovaAA.Sprint2.Task5.V12.Lib;
namespace Tyuiu.PankovaAA.Sprint2.Task5.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 |Выполнила: Панькова А.А.| ПИНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  Спринт #2                                                              *");
            Console.WriteLine("*  Тема: Оператор Switch                                                  *");
            Console.WriteLine("*  Задание #05                                                            *");
            Console.WriteLine("*  Вариант #12                                                            *");
            Console.WriteLine("*  Выполнила: Панькова Ангелина Алексеевна    |ПИНб-25-1|                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  УСЛОВИЕ:                                                               *");
            Console.WriteLine("*  Написать программу, которая использует оператор switch вычисляет       *");
            Console.WriteLine("*  требуемое значение и возвращает результа                               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  ИСХОДНЫЕ ДАННЫЕ:                                                       *");

            int g = 2024;
            int m = 3;
            int n = 15;

            string result = ds.FindDateOfPreviousDay(g, m, n);

            

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"* Дата предыдущего дня: {result}*");
            Console.ReadKey();




        }
    }
}