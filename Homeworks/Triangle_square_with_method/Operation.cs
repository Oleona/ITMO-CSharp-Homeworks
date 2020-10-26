using System;

namespace Triangle_square_with_method
{
    public class Operation
    {
        public static double Triangle_square(double side1, double side2, double side3)
        {
            bool ok = Triangle_existence(side1, side2, side3);
            if (ok)
            {
                double semi_perimetr = (side1 + side2 + side3) / 2;
                return Math.Sqrt((semi_perimetr * (semi_perimetr - side1) * (semi_perimetr - side2) * (semi_perimetr - side3)));
            }
            else
            {
                Console.WriteLine("Triangle not existence");
                return 0;
            }
        }

        private static bool Triangle_existence(double side1, double side2, double side3)
        {           
           return (side1 < side2 + side3) && (side2 < side1 + side3) && (side3 < side1 + side2);
        }

        public static double Triangle_square(double side1)
        {           
            return (Math.Sqrt(3) / 4) * side1 * side1;
        }


    }
}
