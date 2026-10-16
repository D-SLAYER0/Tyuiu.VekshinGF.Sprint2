using Tyuiu.VekshinGF.Sprint2.Task5.V11.Lib;

namespace Tyuiu.VekshinGF.Sprint2.Task3.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Векшин Г. Ф. | ПИНб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Операторы ветвления                                               *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Векшин Г. Ф. | ПИНб-26-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* По заданным g (год), m (месяц), n (день) определить дату следующего     *");
            Console.WriteLine("* дня. Использовать оператор switch. Год не високосный.                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int g, m, n;

            Console.WriteLine("Введите год (g): ");
            g = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите месяц (m, 1-12): ");
            m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите день (n, 1-31): ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.FindDateOfNextDay(g, m, n));

            Console.ReadLine();
        }
    }
}