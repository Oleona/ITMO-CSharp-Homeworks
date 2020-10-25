using System;


namespace target_shooting
{
    public struct hit
    {
        public double x;
        public double y;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number of shots:  ");
            int number_of_shots = int.Parse(Console.ReadLine());

            hit[] hits = new hit[number_of_shots];
            for (int i = 0; i < number_of_shots; i++)
            {
                Console.Write("Enter the coordinates of the shot:   ");
                string[] arr = Console.ReadLine().Split();
                hits[i].x = double.Parse(arr[0]);
                hits[i].y = double.Parse(arr[1]);
            }

            int points = 0;
            Random rnd = new Random();
            double target_center = -10 + rnd.NextDouble() * (20);

            foreach (hit hit in hits)
            {
                double dist = Math.Sqrt(Math.Pow(hit.x - target_center, 2) + Math.Pow(hit.y - target_center, 2));
                if (dist < 1) points += 10;
                else if (dist < 2) points += 5;
                else if (dist < 3) points += 1;
            }

            Console.WriteLine($"Your points are: {points}");
            Console.ReadKey();
        }
    }
}
