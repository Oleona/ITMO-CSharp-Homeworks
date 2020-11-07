using System;


namespace shape_hierarchy
{
    class Quadrate : Shape, IRotatable
    {
        public float side;

        public Quadrate(float side)
        {
            this.side = side;
        }

        public override void print()
        {
            Console.WriteLine($"\nQuadrate side is  { side}");
        }

        public override double getPerimeter() => side * 4;

        public override double getArea() => side * side;

        public void rotate()
        {
            Console.WriteLine("Quadrate rotation");
        }
    }
}
