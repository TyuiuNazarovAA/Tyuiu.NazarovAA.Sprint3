using Tyuiu.NazarovAA.Sprint3.Task5.V12.Lib;

namespace Tyuiu.NazarovAA.Sprint3.Task5.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Назаров А. А. | РППб 25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнил: Назаров Артём Александрович | СППб-25-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить значение     *");
            Console.WriteLine("* функции y=sin(x)/x. При х = 0 прервать цикл                             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите начальное значение внешнего цикла:");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите начальное значение внутреннего цикла:");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите конечное значение внешнего цикла:");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите конечное значение внутреннего цикла:");
            int y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.GetSumSumSeries(5, x1, y1, x2, y2));
        }
    }
}
