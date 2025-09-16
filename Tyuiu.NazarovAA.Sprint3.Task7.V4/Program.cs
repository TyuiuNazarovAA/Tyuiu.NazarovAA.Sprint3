using Tyuiu.NazarovAA.Sprint3.Task7.V4.Lib;

namespace Tyuiu.NazarovAA.Sprint3.Task7.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Назаров А. А. | РППб 25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Назаров Артём Александрович | СППб-25-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Напишите программу, которая выводит таблицу значений функции            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите начальное значение:");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите конечное значение:");
            int x2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double[] mas = ds.GetMassFunction(x1, x2);
            Console.WriteLine("+---------+---------+");
            Console.WriteLine("|    X    |   f(X)  |");
            Console.WriteLine("+---------+---------+");
            for (int i = x1; i <= x2; i++)
            {
                Console.WriteLine("|{0, 5:d}    |{1, 7:f2}  |", i, mas[i - x1]);
            }
            Console.WriteLine("+---------+---------+");
        }
    }
}
