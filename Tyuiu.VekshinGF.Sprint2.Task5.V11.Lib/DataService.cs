using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.VekshinGF.Sprint2.Task5.V11.Lib
{
    public class DataService : ISprint2Task5V11
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            int nextDay = n + 1;
            int nextMonth = m;
            int nextYear = g;

            int daysInMonth;
            switch (m)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    daysInMonth = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    daysInMonth = 30;
                    break;
                case 2:
                    daysInMonth = 28; // год не высокосный
                    break;
                default:
                    return "Неверный месяц";
            }
            if (nextDay > daysInMonth)
            {
                nextDay = 1;
                nextMonth = m + 1;

                if (nextMonth > 12)
                {
                    nextMonth = 1;
                    nextYear = g + 1;
                }
            }

            return $"{nextDay:D2}.{nextMonth:D2}.{nextYear}";
        }
    }
}
