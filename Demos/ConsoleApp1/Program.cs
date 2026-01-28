namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine($"{Program.Factorial(3)}");
        }

        static int Factorial(int n)
        {
            if (n == 0)
                return 1;
            else if (n < 0)
                return -1;
            else if (n > 0)
                return n * Factorial(n - 1);
            return -2;
        }
    }
}
