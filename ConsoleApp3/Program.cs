namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 4;
            int b = 2;
            int c = 1;
            int d = 9;
            int i = 1;
            do
            {
                a--;
                b += a;
                c = b + a;
                d = c - a + i;
                i++;
            } while (i < 5);
            Console.WriteLine(d);
        }
    }
}
