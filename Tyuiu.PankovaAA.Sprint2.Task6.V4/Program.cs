using Tyuiu.PankovaAA.Sprint2.Task6.V4.Lib;
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
            Console.WriteLine("*  Задание #06                                                            *");
            Console.WriteLine("*  Вариант #04                                                            *");
            Console.WriteLine("*  Выполнила: Панькова Ангелина Алексеевна    |ПИНб-25-1|                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  УСЛОВИЕ:                                                               *");
            Console.WriteLine("*  Написать программу, которая использует оператор switch вычисляет       *");
            Console.WriteLine("*  требуемое значение и возвращает результа                               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  ИСХОДНЫЕ ДАННЫЕ:                                                       *");

            Console.WriteLine("Введите номер масти:");
            int numMast = Convert.ToInt32(Console.ReadLine());

            string res;

            if ((numMast < 1) || (numMast > 4))
            {
                res = "Введено неверное значение!";
            }
            else
            {
                res = "Это масть " + ds.FindCardSuit(numMast);

            }
            


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(res);
            Console.ReadKey();




        }
    }
}