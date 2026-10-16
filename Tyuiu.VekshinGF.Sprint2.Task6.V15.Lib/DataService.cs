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
                1 => "Понедельник",
                2 => "Вторник",
                3 => "Среда",
                4 => "Четверг",
                5 => "Пятница",
                6 => "Суббота",
                7 => "Воскресенье",
                _ => "Неизвестно"
            };

            return dayName;
        }
    }
}
