using System;

namespace Math
{
    public class Statistics
    {
        public static T Min<T>(T[] array) where T : IComparable
        {
            if (array.Length == 0)
            {
                throw new ArgumentException(nameof(array) + "cannot be empty.");
            }

            T min = array[0];

            foreach (var item in array)
            {
                if (min.CompareTo(item) > 0)
                {
                    min = item;
                }
            }
            return min;
        }

        public static T Max<T>(T[] array) where T : IComparable
        {
            if (array.Length == 0)
            {
                throw new ArgumentException(nameof(array) + "cannot be empty.");
            }

            T min = array[0];

            foreach (var item in array)
            {
                if (min.CompareTo(item) < 0)
                {
                    min = item;
                }
            }
            return min;
        }

        public static double Median(params double[] array)
        {
            int length = array.Length;

            if (length == 0)
            {
                throw new ArgumentException(nameof(array) + "cannot be empty.");
            }

            Array.Sort(array);

            return
                length % 2 == 0 
                ? (array[length / 2  -1] + array[length / 2 ]) / 2
                : array[length / 2];            
        }

        public static double Median(params int[] array)
        {
            int length = array.Length;

            if (length == 0)
            {
                throw new ArgumentException(nameof(array) + "cannot be empty.");
            }

            Array.Sort(array);

            return
                length % 2 == 0
                ? (array[length / 2-1] + array[length / 2 ]) / 2
                : array[length / 2];
        }

        public static T Dominant<T>(T[] array) where T : IComparable
        {
            var length = array.Length;

            if (length == 0)
            {
                throw new ArgumentException(nameof(array) + "cannot be empty.");
            }

            var dominant_counter = 1;
            T dominant = array[0];

            for (int i = 0; i < length; i++)
            {
                int counter = 0;
                for (int j = i + 1; j < length; j++)
                {
                    if (array[i].CompareTo(array[j]) == 0)
                    {
                        counter++;
                    }                    
                }
                if (counter > dominant_counter)
                {
                    dominant = array[i];
                    dominant_counter = counter;
                }
            }
            return dominant;
        }

        public static double Mean(params double[] array)
        {
            var length = array.Length;

            if (length == 0)
            {
                throw new ArgumentException(nameof(array) + "cannot be empty.");
            }

            double sum = 0;

            foreach (var item in array)
            {
                sum += item;
            }

            return sum / length;
        }

        public static double Mean(params int[] array)
        {
            var length = array.Length;

            if (length == 0)
            {
                throw new ArgumentException(nameof(array) + "cannot be empty.");
            }

            double sum = 0;

            foreach (var item in array)
            {
                sum += item;
            }

            return sum / length;
        }

        public static double GeometricMean(params int[] array)
        {
            var length = array.Length;

            if (length == 0)
            {
                throw new ArgumentException(nameof(array) + "cannot be empty.");
            }

            double product = 1.0;
            foreach (double item in array)
            {
                product *= item;
            }
            return System.Math.Pow(product, 1.0 / length);
        }

        public static double GeometricMean(params double[] array)
        {
            var length = array.Length;

            if (length == 0)
            {
                throw new ArgumentException(nameof(array) + "cannot be empty.");
            }

            double product = 1.0;
            foreach (double item in array)
            {
                product *= item;
            }
            return System.Math.Pow(product, 1.0 / length);
        }



        public static double Sum(params double[] array)
        {
            double sum = 0.0;
            foreach (double item in array)
            {
                sum += item;
            }
            return sum;
        }

        public static int Sum(params int[] array)
        {
            int sum = default(int);

            foreach (int item in array)
            {
                sum += item;
            }
            return sum;
        }

        public static double Mean(params (double Item, double Weight)[] array)
        {
            double sum = 0.0;
            double sum_weight = 0.0;

            foreach (var item in array)
            {
                sum += item.Item * item.Weight;
                sum_weight += item.Weight;
            }

            return sum / sum_weight;
        }
    }
}