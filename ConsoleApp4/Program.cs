namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "sxxrrg x vfrX";
            foreach (var c in str)
            {
                if (c == 'X')
                    Console.WriteLine("+++");
            }
            Console.WriteLine(str);
        }
    }
}
