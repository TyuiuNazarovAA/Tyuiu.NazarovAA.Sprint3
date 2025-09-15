using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.NazarovAA.Sprint3.Task3.V2.Lib
{
    public class DataService : ISprint3Task3V2
    {
        public int GetMaxCharCount(string value, char item)
        {
            int maxCount = 0;
            int count = 0;
            foreach (char c in value)
            {
                if (c == item)
                    count++;
                else
                {
                    maxCount = Math.Max(maxCount, count);
                    count = 0;
                }
            }
            return maxCount;
        }
    }
}
