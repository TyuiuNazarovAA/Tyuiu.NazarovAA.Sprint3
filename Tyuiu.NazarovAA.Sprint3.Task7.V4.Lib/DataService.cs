using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.NazarovAA.Sprint3.Task7.V4.Lib
{
    public class DataService : ISprint3Task7V4
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] mas = new double[len];

            for (int x = startValue; x <= stopValue; x++)
            {
                if (Math.Cos(x) + x == 0)
                    mas[x - startValue] = 0;
                else
                    mas[x - startValue] = Math.Round((2 * x + 6) / (Math.Cos(x) + x) - 3, 2);
            }

            return mas;
        }
    }
}
