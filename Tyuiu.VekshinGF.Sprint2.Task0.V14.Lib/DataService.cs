using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.VekshinGF.Sprint2.Task0.V14.Lib
{

    public class DataService : ISprint2Task0V14
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] result = new bool[]
            {
                x == x,
                x != x,
                y < x,
                y > x,
                y <= x,
                y >= x
            };

            return result;
        }
    }
}
