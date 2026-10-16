using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.VekshinGF.Sprint2.Task3.V1.Lib
{
    public class DataService : ISprint2Task3V1
    {
        public double Calculate(double x)
        {
            double y;

            if (x > 0)
            {
                if (x == 2)
                    y = x + (15.0 / x);
                else
                    y = Math.Exp(x) - 12 * x + Math.Cos(x);
            }

            else if (x > -5 && x < 3)
                y = x + 10 * x - (1.0 / x);

            else if (x < -5)
                y = x + 10 * x - (1.0 / (Math.Pow(x, 3) + 3));

            else
                y = 0;

            return Math.Round(y, 3);


            
        }
    }
}
