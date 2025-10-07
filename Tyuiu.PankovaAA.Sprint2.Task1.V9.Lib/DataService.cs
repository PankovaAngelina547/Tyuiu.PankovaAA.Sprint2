using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.PankovaAA.Sprint2.Task1.V9.Lib
{
    public class DataService : ISprint2Task1V9
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = (a == b) & (c < d);
            res[1] = (a != b) && (c > d) && (a < b);
            res[2] = !(a > b) ^ (c <= d) || (a != b);           
            res[3] = (a < b) && (c == d) | (a > c);             
            res[4] = !(a >= b) || (c != d) ^ (b > c);           
            res[5] = (a <= b) & (c >= d) && !(b < d);

            return res;

        }
    }
}
