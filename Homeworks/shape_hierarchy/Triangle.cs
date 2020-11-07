using System;


namespace shape_hierarchy
{
    class Triangle : Shape, IRotatable
    {
        private float side1;
        private float side2;
        private float side3;

        public Triangle(float side1, float side2, float side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;

            if (!Is_Triangle_Exist(side1, side2, side3))
            {
                throw new Exception("Triangle does not exist");
            }
        }

        public override void print()
        {
            Console.WriteLine($" \nTriangle Side1 is  {side1}  Side2 is  {side2} Side3 is  {side3}");
        }

        public override double getPerimeter() => side1 + side2 + side3;

        public override double getArea()
        {
            double semi_perimetr = getPerimeter() / 2;
            return Math.Sqrt((semi_perimetr * (semi_perimetr - side1) * (semi_perimetr - side2) * (semi_perimetr - side3)));
        }

        public void rotate()
        {
            Console.WriteLine("Triangle rotation. ");
        }

        private bool Is_Triangle_Exist(float side1, float side2, float side3) 
            => (side1 < side2 + side3) && (side2 < side1 + side3) && (side3 < side1 + side2);
    }
}
