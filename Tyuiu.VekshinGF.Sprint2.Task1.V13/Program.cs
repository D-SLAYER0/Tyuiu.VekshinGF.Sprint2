using Tyuiu.VekshinGF.Sprint2.Task1.V13.Lib;

namespace Tyuiu.VekshinGF.Sprint2.Task4.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Векшин Г. Ф. | ПИНб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Операции сравнения и логические операции                          *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: Векшин Г. Ф. | ПИНб-26-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнения и логических операций,        *");
            Console.WriteLine("* которая вернет логическую последовательность:                           *");
            Console.WriteLine("* (True, True, True, True, True, False)                                   *");
            Console.WriteLine("* при a = 145, b = 916, c = 164, d = 137                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int a, b, c, d;

            Console.WriteLine("Введите значение A: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение B: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение C: ");
            c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение D: ");
            d = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            bool[] result = ds.GetLogicOperations(a, b, c, d);
            Console.WriteLine(string.Join(", ", result));

            Console.ReadLine();
        }
    }
}