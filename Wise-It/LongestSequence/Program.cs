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
