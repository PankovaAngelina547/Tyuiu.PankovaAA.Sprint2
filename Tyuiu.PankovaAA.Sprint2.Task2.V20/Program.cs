using Tyuiu.PankovaAA.Sprint2.Task2.V20.Lib;
namespace Tyuiu.PankovaAA.Sprint2.Task2.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 |Выполнила: Панькова А.А.| ПИНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  Спринт #2                                                              *");
            Console.WriteLine("*  Тема: Оператор if - полная и короткая формы записи                     *");
            Console.WriteLine("*  Задание #02                                                            *");
            Console.WriteLine("*  Вариант #20                                                            *");
            Console.WriteLine("*  Выполнила: Панькова Ангелина Алексеевна    |ПИНб-25-1|                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  УСЛОВИЕ:                                                               *");
            Console.WriteLine("*  Написать программу на, которая запрашивает целые значения с клавиатуры *");
            Console.WriteLine("*  и вычисляет находится ли точка с координатами X,Y в заштрихованной     *");
            Console.WriteLine("*  области.                                                               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  ИСХОДНЫЕ ДАННЫЕ:                                                       *");

            Console.WriteLine("Введите значение  переменной Х:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение  переменной Y:");
            int y = Convert.ToInt32(Console.ReadLine());

            
            bool res = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("***************************************************************************");

            if (res)
            {
                Console.WriteLine("Точка находится в заштрихованной области");
            }
            else
            {
                Console.WriteLine("Точка не находится в заштрихованной области");

            }
            Console.ReadKey();
        }
    }
}