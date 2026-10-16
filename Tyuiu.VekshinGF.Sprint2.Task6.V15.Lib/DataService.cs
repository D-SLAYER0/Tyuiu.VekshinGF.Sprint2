using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.VekshinGF.Sprint2.Task6.V15.Lib
{
    public class DataService : ISprint2Task6V15
    {
        public string FindDayName(int k)
        {
            int dayOfWeek = ((k - 1) % 7) + 1;

            // Сокращённая форма switch (switch expression)
            string dayName = dayOfWeek switch
            {
                1 => "понедельник",
                2 => "вторник",
                3 => "среда",
                4 => "четверг",
                5 => "пятница",
                6 => "суббота",
                7 => "воскресенье",
                _ => "неизвестно"
            };

            return dayName;
        }
    }
}
