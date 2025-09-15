namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            int c = 3;
            int d = 4;

            for (int i = 1; i < 4; i++)
            {
                a--;
                b += a;
                c = b + a;
                d = (c - a) + i;
            }
            Console.WriteLine(d);
        }
    }
}
