using System;

namespace Triangle_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Input first side of triangle:  ");
            float side1 = float.Parse(Console.ReadLine());
            Console.WriteLine(" Input second side of triangle:  ");
            float side2 = float.Parse(Console.ReadLine());
            Console.WriteLine(" Input third side of triangle:  ");
            float side3 = float.Parse(Console.ReadLine());

            try
            {

                Triangle triangle1 = new Triangle(side1, side2, side3);
                double perimeter = triangle1.getPerimeter();
                double area = triangle1.getArea();
                Console.WriteLine($" Perimeter is {perimeter}");
                Console.WriteLine($" Area is {area}");
                triangle1.PrintSides();

                Console.WriteLine("For a triangle with sides from the constructor ");
                Triangle triangle2 = new Triangle();
                double perimeter2 = triangle2.getPerimeter();
                double area2 = triangle2.getArea();
                Console.WriteLine($" Perimeter is {perimeter2}");
                Console.WriteLine($" Area is {area2}");
                triangle2.PrintSides();

                Console.WriteLine("For an equilateral triangle ");
                float side = 7.77f;
                Triangle triangle3 = new Triangle(side);
                double perimeter3 = triangle3.getPerimeter();
                double area3 = triangle3.getArea();
                Console.WriteLine($" Perimeter is {perimeter3}");
                Console.WriteLine($" Area is {area3}");
                triangle3.PrintSides();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
