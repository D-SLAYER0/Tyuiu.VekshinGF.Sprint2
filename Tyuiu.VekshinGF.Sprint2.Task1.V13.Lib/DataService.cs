using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.VekshinGF.Sprint2.Task1.V13.Lib
{
    public class DataService : ISprint2Task1V13
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] result = new bool[]
            {
                (a < b) | (c > d),
                (a != b) & (c  != d),
                (a > d) || (b < c),
                (a <= c) && (d < a),
                !(a >= b),
                (a == a) ^ (b == b),
            };

            return result;
        }
    }
}
