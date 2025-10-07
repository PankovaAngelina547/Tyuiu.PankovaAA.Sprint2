using Tyuiu.PankovaAA.Sprint2.Task0.V2.Lib;
namespace Tyuiu.PankovaAA.Sprint2.Task0.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x = 123;
            int y = 123;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            Console.Title = "Спринт #2 |Выполнила: Панькова А.А.| ПИНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  Спринт #2                                                              *");
            Console.WriteLine("*  Тема: Операции сравнения                                               *");
            Console.WriteLine("*  Задание #0                                                             *");
            Console.WriteLine("*  Вариант #2                                                             *");
            Console.WriteLine("*  Выполнила: Панькова Ангелина Алексеевна    |ПИНб-25-1|                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  УСЛОВИЕ:                                                               *");
            Console.WriteLine("*  Написать программу из операций сравнений (==, !=, <, >, <=, >=, после  *");
            Console.WriteLine("*  довательность операций не должна нарушаться) и арифметических          *");
            Console.WriteLine("*  выражений, которая вернет логическую последовательность(массив):       *");
            Console.WriteLine("*  (False, True, False, True, False, True), при x = 123, y = 123          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            
            Console.WriteLine("X=" + x);
            
            Console.WriteLine("Y=" + y);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("***************************************************************************");
            
            for (int i =0; i<6; i++)
                
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();
        }

    }
}