using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.VekshinGF.Sprint2.Task2.V19.Lib
{
    public class DataService : ISprint2Task2V19
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            
            if (x < 1 || x > 15 || y < 1 || y > 15)
                return false;

            
            bool rect1 = (x >= 3 && x <= 4) && (y >= 3 && y <= 7);

            
            bool rect2 = (x >= 9 && x <= 10) && (y >= 3 && y <= 7);

            
            bool rect3 = (x == 11) && (y == 3);

            
            bool rect4 = (x >= 3 && x <= 13) && (y >= 5 && y <= 7);

           
            bool rect5 = (x >= 6 && x <= 8) && (y >= 8 && y <= 11);

            
            bool rect6 = (x >= 11 && x <= 13) && (y >= 8 && y <= 10);

           
            bool rect7 = ((x >= 3 && x <= 5) || (x >= 9 && x <= 11)) && (y == 11);

           
            bool rect8 = (x >= 7 && x <= 11) && (y == 13);

            
            bool rect9 = (x >= 9 && x <= 13) && (y == 14);

            
            return rect1 || rect2 || rect3 || rect4 || rect5 || rect6 || rect7 || rect8 || rect9;
        }
    }
}
