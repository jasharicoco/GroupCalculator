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
            Console.WriteLine("5. Avsluta programmet");

            bool menu = true;
            while (menu)
                {
                Int32.TryParse(Console.ReadLine(), out int choice);

                switch (choice)
                    {
                    case 1:
                        //metod för addition
                        break;
                    case 2:
                        //metod för subtraktion
                        break;
                    case 3:
                        //metod för multiplikation
                        break;
                    case 4:
                        //metod för division
                        break;
                    case 5:
                        menu = false;
                        break;
                    default: Console.WriteLine("Ogiltlig inmatning."); break;
                    }
                }


            static double Multiplication(double a, double b)
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

            static double SquareRoot(int a)
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
