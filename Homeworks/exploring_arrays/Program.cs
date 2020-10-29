using System;

namespace exploring_arrays
{
    class Program
    {

        public static int get_sum_of_elements(int[] array)
        {
            int sum = 0;
            foreach (int arr in array)
            {
                sum += arr;
            }
            return sum;
        }

        public static double get_average(int[] array)
        {
            double average = (get_sum_of_elements(array) / (double)array.Length);
            return average;
        }

        public static void get_negative_and_positive_sum(int[] array, out int positive_sum, out int negative_sum)
        {
            negative_sum = 0;
            positive_sum = 0;
            foreach (int arr in array)
            {
                if (arr >= 0) positive_sum += arr;
                else negative_sum += arr;
            }
        }

        public static void get_sum_even_and_odd(int[] array, out int even_sum, out int odd_sum)
        {
            even_sum = 0;
            odd_sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0) even_sum += array[i];
                else odd_sum += array[i];
            }
        }

        public static int get_max_and_min(int[] array, out int index_max, out int index_min)
        {
            index_max = 0;
            index_min = 0;
            int max = array[0];
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    index_max = i;
                }
                else if (array[i] < min)
                {
                    min = array[i];
                    index_min = i;
                }
            }
            int composition = 1;
            for (int i = ((index_min < index_max) ? index_min : index_max); i <= ((index_min < index_max) ? index_max : index_min); i++)
            {
                composition *= array[i];
            }
            return composition;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Input the number of elements of the array:  ");
            int number_of_elements = int.Parse(Console.ReadLine());

            int[] myArray = new int[number_of_elements];
            for (int i = 0; i < number_of_elements; i++)
            {
                Console.Write("Input the value of the array element:   ");
                myArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"sum of elements is {get_sum_of_elements(myArray)}");

            Console.WriteLine($"average of elements is {get_average(myArray)}");


            int positiv_sum, negativ_sum;
            get_negative_and_positive_sum(myArray, out positiv_sum, out negativ_sum);
            Console.WriteLine($"sum of positive elements is { positiv_sum}");
            Console.WriteLine($"sum of negativ elements is { negativ_sum}");

            int even_sum, odd_sum;
            get_sum_even_and_odd(myArray, out even_sum, out odd_sum);
            Console.WriteLine($"sum of even elements is { even_sum}");
            Console.WriteLine($"sum of odd elements is { odd_sum}");

            int index_max, index_min;
            get_max_and_min(myArray, out index_max, out index_min);
            Console.WriteLine($"max elements index is { index_max} its meaning {myArray[index_max]}");
            Console.WriteLine($"min elements index is { index_min} its meaning {myArray[index_min]}");
            Console.WriteLine($"composition of numbers between the maximum and minimum element is {get_max_and_min(myArray, out index_max, out index_min)}");


            Console.ReadKey();
        }
    }
}
