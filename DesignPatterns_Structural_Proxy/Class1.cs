using System;
using static System.Console;
namespace DesignPatterns_Structural_Proxy
{
    internal class Class1
    {
        private static int myXOR(int x, int y)
        {
            return (x | y) & (~x | ~y);
        }
        //public struct Result
        //{
        //    public int a, b;
        //    public override string ToString()
        //    {
        //        return $"{a} {b}";
        //    }
        //}
        public static void Main(string[] args)
        {
            int lo, hi, a, k, max = 0;
            //Result res = new Result();
            int[] arr = Array.ConvertAll(ReadLine().Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries), item => Convert.ToInt32(item));
            lo = arr[0];
            hi = arr[1];
            k = arr[2];
            for (int i = lo; i < hi; i++)
            {
                for (int j = i + 1; j <= hi; j++)
                {
                    a = myXOR(i, j);
                    if (a <= k && a > max)
                    {
                        max = a;
                        //res.a = i;
                        //res.b = j;
                    }
                }
            }
            //WriteLine(res);
            WriteLine(max);
        }

    }
}
