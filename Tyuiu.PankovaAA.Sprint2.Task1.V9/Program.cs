using Tyuiu.PankovaAA.Sprint2.Task1.V9.Lib;
namespace Tyuiu.PankovaAA.Sprint2.Task1.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int a = 15;
            int b = 335;
            int c = 174;
            int d = 478;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);
            Console.Title = "Спринт #2 |Выполнила: Панькова А.А.| ПИНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  Спринт #2                                                              *");
            Console.WriteLine("*  Тема: Операции сравнения                                               *");
            Console.WriteLine("*  Задание #01                                                            *");
            Console.WriteLine("*  Вариант #9                                                             *");
            Console.WriteLine("*  Выполнила: Панькова Ангелина Алексеевна    |ПИНб-25-1|                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  УСЛОВИЕ:                                                               *");
            Console.WriteLine("*  Написать программу из операций сравнений (==, !=, <, >, <=, >=,        *");
            Console.WriteLine("*  оследовательность можно чередовать, но использовать один раз в         *");
            Console.WriteLine("*  выражении) и логических операций (|, &, ||, &&, !, последовательность  *");
            Console.WriteLine("*  (операций не должна нарушаться), а также арифметических выражений,     *");
            Console.WriteLine("*  которая вернет логическую последовательность(массив)                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  ИСХОДНЫЕ ДАННЫЕ:                                                       *");
           
            
            Console.WriteLine("a =" + a);
            Console.WriteLine("b =" + b);
            Console.WriteLine("c =" + c);
            Console.WriteLine("d =" + d);




            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("***************************************************************************");

            for (int i=0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();
        }

    }
}