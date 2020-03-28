using System;

namespace Math
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Random random = new Random(0);

            var array = new int[1000];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(array.Length);
            }

            Console.WriteLine(Statistics.Min(array));
            Console.WriteLine(Statistics.Max(array));
            Console.WriteLine(Statistics.Median(array));
            Console.WriteLine(Statistics.Dominant(array));
            Console.WriteLine(Statistics.Mean(array));
            Console.ReadLine();
        }
    }
}
