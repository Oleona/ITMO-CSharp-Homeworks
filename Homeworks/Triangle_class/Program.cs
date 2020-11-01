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
                double perimeter = triangle1.getPerimeter(side1, side2, side3);
                double area = triangle1.getArea(side1, side2, side3);

                triangle1.PrintSides();
                Console.WriteLine($" Perimeter is {perimeter}");
                Console.WriteLine($" Area is {area}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
