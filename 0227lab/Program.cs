using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0227lab
{
    class Program
    {
        public static T Max<T>(T a, T b, T c) where T:IComparable<T>
        {
            if (a.CompareTo(b)>0&&a.CompareTo(c)>0)
            {
                return a;
            }
            else if (b.CompareTo(a) > 0 && b.CompareTo(c) > 0)
            {
                return b;
            }
            else 
            {
                return c;
            }
        }

        public static T Min<T>(T a,T b, T c) where T : IComparable<T>
        {
            if (a.CompareTo(b) < 0&& a.CompareTo(c) < 0)
            {
                return a;
            }
            else if (b.CompareTo(a) < 0 && b.CompareTo(c) < 0)
            {
                return b;
            }
            else
            {
                return c;
            }
        }
        public static T Sum<T>(T[] arr)
        {
            T sum = default(T);
            for(int i = 0; i < arr.Length; i++)
            {
                sum=sum + (dynamic)arr[i];
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int MaxValue = Max<int>(11, 12, 9);
            Console.WriteLine(MaxValue);

            int MinValue = Min<int>(11, 12, 9);
            Console.WriteLine(MinValue);
        }
    }
}
