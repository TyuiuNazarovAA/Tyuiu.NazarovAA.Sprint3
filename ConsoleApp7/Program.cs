namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int x;
            for (x = 2; x <= 6; x++)
            {
                for (int d = 1; d <= x; d++)
                {
                    if (x % d == 0 && d < 3)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
