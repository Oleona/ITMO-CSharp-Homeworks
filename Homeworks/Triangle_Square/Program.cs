using System;

namespace TriangleSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Input triangle perimeter");
            double Perimeter = double.Parse(Console.ReadLine());

            double Square = Math.Sqrt(Perimeter / 2 * (Perimeter / 6) * (Perimeter / 6) * (Perimeter / 6));
            double SquareVariant = Math.Sqrt(3) / 4 * (Perimeter / 3) * (Perimeter / 3);
            Console.WriteLine($"\tside      result  \n\t{Perimeter / 3:F2}      {Square:F2}\n");
            Console.WriteLine($"\tside      result  \n\t{Perimeter / 3:F2}      {SquareVariant:F2}");
            Console.ReadKey();
        }
    }
}
