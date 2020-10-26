using System;

namespace Triangle_square_with_method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the type of triangle. If equilateral - enter y, otherwise enter n ");
            string answer = Console.ReadLine();
            if (answer == "y")
            {
                Console.WriteLine("Enter side of triangle");
                double side = double.Parse(Console.ReadLine());
                double square = Operation.Triangle_square(side);
                Console.WriteLine($"Square of triangle is {square}");
            }
            else
            {
                Console.WriteLine("Enter side1 of triangle");
                double side1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter side2 of triangle");
                double side2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter side3 of triangle");
                double side3 = double.Parse(Console.ReadLine());

                double square = Operation.Triangle_square(side1, side2, side3);
                if (square > 0)
                    Console.WriteLine($"Square of triangle is {square}");
            }
            Console.ReadKey();
        }
    }
}
