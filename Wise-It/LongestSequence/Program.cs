using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestSequence
{
    class Program
    {
        private static List<int> theSequance = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
        static void Main(string[] args)
        {
            //// Declare the array of two elements:
            //int[][] arr = new int[3][];
            //// Initialize the elements:
            //arr[0] = new int[3] { 11, 2, 4 };
            //arr[1] = new int[3] { 4, 5, 6 };
            //arr[2] = new int[3] { 10, 8, -12 };
            //Console.WriteLine(DiagonalOperations.Difference(arr));


            //Console.WriteLine(Fraction.PositiveFraction(new int[6] { -4, 3, -9, 0, 4, 1 }));
            //Console.WriteLine(Fraction.NegativeFraction(new int[6] { -4, 3, -9, 0, 4, 1 }));
            //Console.WriteLine(Fraction.ZeroFraction(new int[6] { -4, 3, -9, 0, 4, 1 }));

            //TextAlignment.Staircase(6);

            //Console.WriteLine(MiniMax.MinSum(new int[5] { 793810624, 895642170, 685903712, 623789054, 468592370 }));
            //Console.WriteLine(MiniMax.MaxSum(new int[5] { 793810624, 895642170, 685903712, 623789054, 468592370 }));

            Console.WriteLine(HeighestIntNumber.GetHighestNumber(new int[4] { 4,3,1,4}));

            Solution();
            Console.ReadKey();


        }
        public static void Solution()
        {
            // You can initiate and calculate things here
            theSequance = GetLongestSequance(theSequance);
            foreach (var item in theSequance)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine(GetStartDay().ToString());
            Console.WriteLine(GetEndDay().ToString());
        }

        public static List<int> GetLongestSequance(List<int> theSequance)
        {

            theSequance.Sort();

            List<int> result = new List<int>();

            int longestSequenceLength = 0;
            int startIndexOfLongestSequence = 0;
            int currentSequenceLength = 0;
            int currentStartSequenceIndex = 0;

            for (int i = 0; i < theSequance.Count; i++)
            {
                if (i == 0 || theSequance[i] != theSequance[i - 1] + 1)
                {
                    currentSequenceLength = 1;
                    currentStartSequenceIndex = i;
                }
                else
                {
                    currentSequenceLength++;
                }

                if (currentSequenceLength > longestSequenceLength)
                {
                    longestSequenceLength = currentSequenceLength;
                    startIndexOfLongestSequence = currentStartSequenceIndex;
                }
            }
            result.AddRange(theSequance.Skip(startIndexOfLongestSequence)
               .Take(longestSequenceLength)
               .Where(day => ApiClass.GetTemperatureOnDay(day) <= 5));

            return result;
        }

        public static int GetStartDay()
        {
            // Write your code here
            return ApiClass.GetTemperatureOnDay(theSequance.First());
        }

        public static int GetEndDay()
        {
            // Write your code here
            return ApiClass.GetTemperatureOnDay(theSequance.Last());
        }



        // ************************ Old code
        //List<int> sequance = new List<int> { 1, 4, 5, 6, 3, 7, 8, 20, 24, 25, 26, 30 };

        //sequance.Sort();

        //List<int> result = new List<int>();
        //result.IndexOf()
        //int longestSequenceLength = 0;
        //int startIndexOfLongestSequence = 0;
        //int currentSequenceLength = 0;
        //int currentStartSequenceIndex = 0;

        //for (int i = 0; i < sequance.Count; i++)
        //{
        //    if (i == 0 || sequance[i] != sequance[i - 1] + 1)
        //    {
        //        currentSequenceLength = 1;
        //        currentStartSequenceIndex = i;
        //    }
        //    else
        //    {
        //        currentSequenceLength++;
        //    }

        //    if (currentSequenceLength > longestSequenceLength)
        //    {
        //        longestSequenceLength = currentSequenceLength;
        //        startIndexOfLongestSequence = currentStartSequenceIndex;
        //    }
        //}
        //result.AddRange(sequance.Skip(startIndexOfLongestSequence)
        //   .Take(longestSequenceLength).Where(nr => GetTempOfTheDay(nr) <= 5));
        //Console.WriteLine(string.Join(",", result));

        //Console.WriteLine(string.Join(",", sequance.Skip(startIndexOfLongestSequence)
        //   .Take(longestSequenceLength)));
        //var A = new[] { 1, 3, 6, 4, 1, 2 };
        //Console.WriteLine(Solution(A));




        // ************************ Old Code
        //public static int GetTempOfTheDay(int nr)
        //{
        //    //return new Random().Next(1,25);
        //    return nr + 1;
        //}


        //public static int Solution(int[] A)
        //{
        //    // write your code in C# 6.0 with .NET 4.5 (Mono)
        //    var numbers = Enumerable.Range(1, Math.Abs(A.Max()) + 1).ToArray();
        //    return numbers.Except(A).ToArray()[0];
        //}

        //        #region WiseCode
        //        using System;
        //        using System.Collections.Generic;
        //    using System.Linq;

        //public class Solution : ISolution
        //    {
        //        List<int> theSequance = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
        //        public Solution()
        //        {
        //            // You can initiate and calculate things here
        //            theSequance = GetLongestSequance(theSequance);
        //            foreach (var item in theSequance)
        //            {
        //                Console.WriteLine(item.ToString());
        //            }

        //            Console.WriteLine(GetStartDay().ToString());
        //            Console.WriteLine(GetEndDay().ToString());
        //        }

        //        /**
        //         * Return the start day for the longest sequence of days where the mean temperature
        //         * is within five degrees.
        //         */
        //        public int GetStartDay()
        //        {
        //            // Write your code here
        //            return API.GetTemperatureOnDay(theSequance.First());
        //        }

        //        /**
        //         * Return the end day for the longest sequence of days where the mean temperature is
        //         * within five degrees. Note that the start and end day of the sequence may be the
        //         * same.
        //         */
        //        public int GetEndDay()
        //        {
        //            // Write your code here
        //            return API.GetTemperatureOnDay(theSequance.Last());
        //        }

        //        public List<int> GetLongestSequance(List<int> theSequance)
        //        {

        //            theSequance.Sort();

        //            List<int> result = new List<int>();

        //            int longestSequenceLength = 0;
        //            int startIndexOfLongestSequence = 0;
        //            int currentSequenceLength = 0;
        //            int currentStartSequenceIndex = 0;

        //            for (int i = 0; i < theSequance.Count; i++)
        //            {
        //                if (i == 0 || theSequance[i] != theSequance[i - 1] + 1)
        //                {
        //                    currentSequenceLength = 1;
        //                    currentStartSequenceIndex = i;
        //                }
        //                else
        //                {
        //                    currentSequenceLength++;
        //                }

        //                if (currentSequenceLength > longestSequenceLength)
        //                {
        //                    longestSequenceLength = currentSequenceLength;
        //                    startIndexOfLongestSequence = currentStartSequenceIndex;
        //                }
        //            }
        //            result.AddRange(theSequance.Skip(startIndexOfLongestSequence)
        //               .Take(longestSequenceLength)
        //               .Where(day => API.GetTemperatureOnDay(day) <= 5));

        //            return result;
        //        }
        //    }
        //    #endregion
    }
}
