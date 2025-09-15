using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.NazarovAA.Sprint3.Task0.V1.Lib
{
    public class DataService : ISprint3Task0V1
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double sum = 0;
            for (int i = startValue; i < stopValue + 1; i++)
            {
                sum += value * value * i + 1;
            }
            return sum;
        }
    }
}
