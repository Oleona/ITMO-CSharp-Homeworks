using System;

namespace Triangle_class
{
    class Triangle
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

        public double getArea(float side1, float side2, float side3)
        {
            double semi_perimetr = getPerimeter(side1, side2, side3) / 2;
            return Math.Sqrt((semi_perimetr * (semi_perimetr - side1) * (semi_perimetr - side2) * (semi_perimetr - side3)));
        }

        public double getPerimeter(float side1, float side2, float side3)
        {
            return (side1 + side2 + side3);
        }

        public bool Is_Triangle_Exist(float side1, float side2, float side3)
        {
            return (side1 < side2 + side3) && (side2 < side1 + side3) && (side3 < side1 + side2);
        }

        public void PrintSides()
        {
            Console.WriteLine($" Side1 is  {side1}");
            Console.WriteLine($" Side2 is  {side2}");
            Console.WriteLine($" Side3 is  {side3}");
        }
    }
}

