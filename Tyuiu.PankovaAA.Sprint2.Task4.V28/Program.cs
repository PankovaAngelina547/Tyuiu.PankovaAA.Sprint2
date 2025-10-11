using Tyuiu.PankovaAA.Sprint2.Task4.V28.Lib;
namespace Tyuiu.PankovaAA.Sprint2.Task4.V28
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 |Выполнила: Панькова А.А.| ПИНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  Спринт #2                                                              *");
            Console.WriteLine("*  Тема: Тернарный оператор                                               *");
            Console.WriteLine("*  Задание #04                                                            *");
            Console.WriteLine("*  Вариант #28                                                            *");
            Console.WriteLine("*  Выполнила: Панькова Ангелина Алексеевна    |ПИНб-25-1|                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  УСЛОВИЕ:                                                               *");
            Console.WriteLine("*  Написать программу, которая вычисляет требуемое значение функции Y с   *");
            Console.WriteLine("*  использованием вложенных оператор if-else, где пользователь вводит     *");
            Console.WriteLine("*  значение переменной X с клавиатуры.                                    *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  ИСХОДНЫЕ ДАННЫЕ:                                                       *");

            Console.WriteLine("Введите значение  переменной Х:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение  переменной Y:");
            double y = Convert.ToDouble(Console.ReadLine());

            double res = ds.Calculate(x,y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Значение функции =" + res);
            Console.ReadKey();
        }
    }
}