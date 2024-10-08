﻿namespace Kalkylator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen\nVad vill du göra?");
            bool menu = true;
            while (menu)
            {

                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraktion");
                Console.WriteLine("3. Multiplikation");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Beräkna arean av en kvadrat");
                Console.WriteLine("6. Beräkna arean av en triangel");
                Console.WriteLine("7. Roten ur");
                Console.WriteLine("8. Avsluta programmet");

                Int32.TryParse(Console.ReadLine(), out int choice);

                double a, b;

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Vilka tal vill du addera?");
                        double.TryParse(Console.ReadLine(), out a);
                        double.TryParse(Console.ReadLine(), out b);
                        Console.WriteLine(Addition(a, b));
                        break;
                    case 2:
                        Console.WriteLine("Vilka tal vill du subtrahera?");
                        double.TryParse(Console.ReadLine(), out a);
                        double.TryParse(Console.ReadLine(), out b);
                        Console.WriteLine(Subtraction(a, b));
                        break;
                    case 3:
                        Console.WriteLine("Vilka tal vill du multiplicera?");
                        double.TryParse(Console.ReadLine(), out a);
                        double.TryParse(Console.ReadLine(), out b);
                        Console.WriteLine(Multiplication(a, b));
                        break;
                    case 4:
                        Console.WriteLine("Vilka tal vill du dividera?");
                        double.TryParse(Console.ReadLine(), out a);
                        double.TryParse(Console.ReadLine(), out b);
                        Console.WriteLine(Division(a, b));
                        break;
                    case 5:
                        Console.WriteLine("Hur långa är sidorna på din rektangel?");
                        double.TryParse(Console.ReadLine(), out a);
                        double.TryParse(Console.ReadLine(), out b);
                        Console.WriteLine(AreaSquare(a, b));
                        break;
                    case 6:
                        Console.WriteLine("Vad är triangelns bas- och höjd?");
                        double.TryParse(Console.ReadLine(), out a);
                        double.TryParse(Console.ReadLine(), out b);
                        Console.WriteLine(AreaTriangle(a, b));
                        break;
                    case 7:
                        Console.WriteLine("Vilket tal vill ta roten ur?");
                        double.TryParse(Console.ReadLine(), out a);
                        Console.WriteLine(SquareRoot(a));
                        break;
                    case 8:
                        menu = false;
                        Environment.Exit(0);
                        break;
                    default: Console.WriteLine("Ogiltlig inmatning."); break;
                }
                Console.ReadLine();
                Console.Clear();
            }


            static double Multiplication(double a, double b)
            {
                return a * b;
            }

            static double Division(double a, double b)
            {
                return a / b;
            }

            static double AreaSquare(double a, double b)
            {
                return a * b;
            }

            static double AreaTriangle(double a, double b)
            {
                return (a * b) / 2;
            }

            static double Addition(double a, double b)
            {
                return a + b;
            }

            static double SquareRoot(double a)
            {
                return Math.Sqrt(a);
            }


            static double Subtraction(double a, double b)
            {
                return a - b;
            }
        }
    }
}
