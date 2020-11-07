using System;


namespace shape_hierarchy
{
    class Circle : Shape
    {
        public float radius;

        public Circle(float radius)
        {
            this.radius = radius;
        }

        public override void print()
        {
            Console.WriteLine($"\nCircle radius is  {radius}");
        }

        public override double getPerimeter() => 2 * Math.PI * radius;

        public override double getArea() => Math.PI * radius * radius;

    }
}
