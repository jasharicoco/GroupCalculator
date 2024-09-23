namespace Kalkylator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen\n\nVad vill du göra?");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraktion");
            Console.WriteLine("3. Multiplikation");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Beräkna arean av en kvadrat");
            Console.WriteLine("6. Beräkna arean av en triangel");
            Console.WriteLine("7. Avsluta programmet");

            bool menu = true;
            while (menu)
            {
                Int32.TryParse(Console.ReadLine(), out int choice);

                double a, b;

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Vilka tal vill du addera?");
                        double.TryParse(Console.ReadLine(), out a);
                        double.TryParse(Console.ReadLine(), out b);
                        Console.WriteLine(Addition(a, b));
                        menu = false;
                        break;
                    case 2:
                        Console.WriteLine("Vilka tal vill du subtrahera?");
                        double.TryParse(Console.ReadLine(), out a);
                        double.TryParse(Console.ReadLine(), out b);
                        Console.WriteLine(Subtraction(a, b));
                        menu = false;
                        break;
                    case 3:
                        Console.WriteLine("Vilka tal vill du multiplicera?");
                        double.TryParse(Console.ReadLine(), out a);
                        double.TryParse(Console.ReadLine(), out b);
                        Console.WriteLine(Multiplication(a, b));
                        menu = false;
                        break;
                    case 4:
                        Console.WriteLine("Vilka tal vill du dividera?");
                        double.TryParse(Console.ReadLine(), out a);
                        double.TryParse(Console.ReadLine(), out b);
                        Console.WriteLine(Division(a, b));
                        menu = false;
                        break;
                    case 5:
                        Console.WriteLine("Hur långa är sidorna på din rektangel?");
                        double.TryParse(Console.ReadLine(), out a);
                        double.TryParse(Console.ReadLine(), out b);
                        Console.WriteLine(AreaSquare(a, b));
                        menu = false;
                        break;
                    case 6:
                        Console.WriteLine("Vad är triangelns bas- och höjd?");
                        double.TryParse(Console.ReadLine(), out a);
                        double.TryParse(Console.ReadLine(), out b);
                        Console.WriteLine(AreaTriangle(a, b));
                        menu = false;
                        break;
                    case 7:
                        menu = false;
                        break;
                    default: Console.WriteLine("Ogiltlig inmatning."); break;
                }
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
}
