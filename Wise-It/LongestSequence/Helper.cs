using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestSequence
{
    public class ListTypeClass<T> : List<T>
    {
        public IEnumerable<T> Where(Func<T, Boolean> predicate)
        {
            return Enumerable.Where(this, predicate);
        }
    }

    public static class CompareTest
    {
        public static int CompareInt(int valueOne, int valueTwo)
        {
            //Console.WriteLine(CompareTest.CompareInt(2, 8));
            return valueOne.CompareTo(valueTwo);
        }
    }
    /// <summary>
    /// Operate on Jaggade Matrix array
    /// </summary>
    public static class DiagonalOperations
    {
        /// <summary>
        /// Find the Difference between Matrix Diagonal
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int Difference(int[][] arr)
        {
            int result = 0;
            result = DiagonalSum(arr) - DiagonalReverseSum(arr);
            return Math.Abs(result);
        }

        public static int DiagonalSum(int[][] arr)
        {
            int sumResult = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (i == j)
                    {
                        sumResult = sumResult + arr[i][j];
                    }
                }
            }
            return sumResult;
        }
        public static int DiagonalReverseSum(int[][] arr)
        {
            int sumResult = 0;
            int i=0;
            int j= arr.Length-1;

            while (i<arr.Length && j>=0)
            {
                sumResult = sumResult + arr[i][j];
                i++;
                j--;
            }
            return sumResult;
        }
    }

    public static class Fraction
    {
        public static string PositiveFraction(int[] arr)
        {
            var result = arr.Where(x => x > 0).ToList();
            return (result.Count() / (float)arr.Count()).ToString("0.000000");
        }
        public static string NegativeFraction(int[] arr)
        {
            var result = arr.Where(x => x < 0).ToList();
            return (Math.Abs(result.Count() / (float)arr.Count())).ToString("0.000000");
        }
        public static string ZeroFraction(int[] arr)
        {
            var result = arr.Where(x => x == 0).ToList();
            return (result.Count() / (float)arr.Count()).ToString("0.000000");
        }
    }

    public static class TextAlignment
    {
        public static string Staircase(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(new String(' ', n - i) + new String('#', i));
            }
            return String.Format("{0,6}","#");
        }
    }

    public static class MiniMax
    {
        public static double MinSum(int[] arr)
        {
            double sum = 0;
            Array.Sort(arr);
            for (int i = 0; i < arr.Length-1; i++)
            {
                sum = sum + arr[i];
            }
            return sum;
        }
        public static double MaxSum(int[] arr)
        {
            double sum = 0;
            Array.Sort(arr);
            for (int i = 1; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            return sum;
        }
    }
}
