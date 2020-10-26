using System;

namespace Equation_roots
{
    class Calculations
    {
        public static int GetRoots(double coefficient1, double coefficient2, double coefficient3, out double? root1, out double? root2)
        {
            double discriminant = coefficient2 * coefficient2 - 4 * coefficient1 * coefficient3;
            if (discriminant < 0)
            {
                root1 = root2 = null;
                return -1;
            }

            if (discriminant == 0)
            {
                root1 = root2 = -coefficient2 / (2 * coefficient1);
                return 0;
            }
            else
            {
                root1 = (-coefficient2 + Math.Sqrt(discriminant)) / (2 * coefficient1);
                root2 = (-coefficient2 - Math.Sqrt(discriminant)) / (2 * coefficient1);
                return 1;
            }
        }
    }
}
