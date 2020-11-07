using System;


namespace shape_hierarchy
{
    class Hierarchy_Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Input first side of triangle:  ");
            float side1 = float.Parse(Console.ReadLine());
            Console.WriteLine(" Input second side of triangle:  ");
            float side2 = float.Parse(Console.ReadLine());
            Console.WriteLine(" Input third side of triangle:  ");
            float side3 = float.Parse(Console.ReadLine());

            Console.WriteLine(" Input side of Quadrate:  ");
            float side = float.Parse(Console.ReadLine());

            Console.WriteLine(" Input radius of Circle:  ");
            float radius = float.Parse(Console.ReadLine());


            try
            {

                Triangle triangle1 = new Triangle(side1, side2, side3);
                double perimeter = triangle1.getPerimeter();
                double area = triangle1.getArea();
                triangle1.print();
                Console.WriteLine($"Triangle Perimeter is {perimeter}");
                Console.WriteLine($"Triangle Area is {area}");
                triangle1.rotate();
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Quadrate quadrate1 = new Quadrate(side);
            double perimeter1 = quadrate1.getPerimeter();
            double area1 = quadrate1.getArea();
            quadrate1.print();
            Console.WriteLine($"Quadrate Perimeter is {perimeter1}");
            Console.WriteLine($"Quadrate Area is {area1}");
            quadrate1.rotate();


            Circle circle1 = new Circle(radius);
            double circuit = circle1.getPerimeter();
            double area2 = circle1.getArea();
            circle1.print();
            Console.WriteLine($"Circle circuit (Perimeter) is {circuit}");
            Console.WriteLine($"Circle Area is {area2}");

            Console.ReadKey();
        }
    }
}
