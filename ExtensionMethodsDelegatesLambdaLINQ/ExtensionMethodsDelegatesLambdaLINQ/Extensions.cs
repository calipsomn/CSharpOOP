using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ExtensionMethodsDelegatesLambdaLINQ
{
    public static class Extensions
    {
        public static StringBuilder SubString(this StringBuilder sb, int index, int length)
        {
            return new StringBuilder(sb.ToString(index, length));
        }

        public static T Sum<T>(this IEnumerable<T> collection)
           where T : struct
        {
            T sum = default(T);
            foreach (var number in collection)
            {
                sum += (dynamic)number;
            }
            return sum;
        }

        public static T Product<T>(this IEnumerable<T> collection)
           where T : struct
        {
            T sum = default(T);
            foreach (var number in collection)
            {
                sum *= (dynamic)number;
            }
            return sum;
        }

        public static T Min<T>(this IEnumerable<T> collection)
           where T : struct
        {
            T min = collection.First();
            foreach (var number in collection)
            {
                if (min > (dynamic)number)
                    min = (dynamic)number;
            }
            return min;
        }

        public static T Max<T>(this IEnumerable<T> collection)
           where T : struct
        {
            T max = collection.First();
            foreach (var number in collection)
            {
                if (max < (dynamic)number)
                    max = (dynamic)number;
            }
            return max;
        }

        public static T Average<T>(this IEnumerable<T> collection)
           where T : struct
        {
            T sum = default(T);
            foreach (var number in collection)
            {
                sum += (dynamic)number;
            }
            return (dynamic)sum / collection.Count();
        }
    }
}
