using System;

namespace Distance
{
    public struct Distance
    {
        public int foot;
        public int inch;
    }

    class HomeWorkDistance
    {
        static void Main(string[] args)
        {
            Distance Distance1, Distance2, Distance3;

            Console.Write("Enter Distance1 foot  ");
            Distance1.foot = int.Parse(Console.ReadLine());
            Console.Write("Enter Distance1 inch  ");
            Distance1.inch = int.Parse(Console.ReadLine());

            Console.Write("Enter Distance2 foot  ");
            Distance2.foot = int.Parse(Console.ReadLine());
            Console.Write("Enter Distance2 inch  ");
            Distance2.inch = int.Parse(Console.ReadLine());

            Distance3.foot = Distance1.foot + Distance2.foot + (int)((Distance1.inch + Distance2.inch) / 12);
            Distance3.inch = (Distance1.inch + Distance2.inch) % 12;

            Console.WriteLine($"Distance1 is {Distance1.foot}'- {Distance1.inch}\" ");
            Console.WriteLine($"Distance2 is {Distance2.foot}'- {Distance2.inch}\" ");
            Console.WriteLine($"Distance3 is {Distance3.foot}'- {Distance3.inch}\" ");
            Console.ReadKey();
        }
    }
}
