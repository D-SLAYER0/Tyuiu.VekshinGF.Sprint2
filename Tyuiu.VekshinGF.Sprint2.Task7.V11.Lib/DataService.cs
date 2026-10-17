using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.VekshinGF.Sprint2.Task7.V11.Lib
{
    public class DataService : ISprint2Task7V11
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool inCircle = (x * x + y * y) <= 1;


            bool cutSector1 = (x > 0) && (y > 0) && (y < x);

            
            bool cutSector2 = (x > 0) && (y < 0);


            return inCircle && !cutSector1 && !cutSector2;
        }
    }
}
