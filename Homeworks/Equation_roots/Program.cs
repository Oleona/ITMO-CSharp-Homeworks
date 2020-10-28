using System;

namespace Equation_roots
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first quadratic equation");
            double coefficient1 = double.Parse(Console.ReadLine());
            Console.WriteLine("enter the second quadratic equation");
            double coefficient2 = double.Parse(Console.ReadLine());
            Console.WriteLine("enter the third  quadratic equation");
            double coefficient3 = double.Parse(Console.ReadLine());

            double? root1, root2;
            Calculations.GetRoots(coefficient1, coefficient2, coefficient3, out root1, out root2);

            if (root1 == null || root2 == null)
            {
                Console.WriteLine($"No roots of the equation with coefficients a = {coefficient1}, b = {coefficient2}, c = {coefficient3}");
                Console.ReadKey();
                return;
            }

            if (Math.Abs(root1.Value - root2.Value) < 0.0001)
            {
                Console.WriteLine($"One root of the equation with coefficients a = {coefficient1}, b = {coefficient2}, c ={coefficient3}: x1 = x2 = {root1}");
            }
            else
            {
                Console.WriteLine($"Roots of the equation with coefficients a = {coefficient1}, b = {coefficient2}, c ={coefficient3} are equal: x1 = {root1}, x2 = {root2} ");
            }
            Console.ReadKey();
        }
    }
}
