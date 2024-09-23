namespace Kalkylator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }


        static int Multiplication(int a, int b)
        {
            return a * b;
        }

        static double Division(int a, int b)
        {
            return a / b;
        }

        static double Division(double a, double b)
            {
              return a / b;
            }


        static int Addition(int a, int b)
        {
            return a + b;
        }

        static double SquareRoot(int a)
        {
            return Math.Sqrt(a);
        }
        

        static int Subtraction(int a, int b)
        {
            return a - b;
        }
    }
}
