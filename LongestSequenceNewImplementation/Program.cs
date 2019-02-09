using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestSequenceNewImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadKey();


            /**
             * using System; 
             * public class Solution : ISolution 
             * { 
             * int totalNumberDays = 0; 
             * int startIndex; int endIndex; 
             * int start; 
             * public Solution() { 
             * // You can initiate and calculate things here 
             * totalNumberDays = API.GetNumDays(); 
             * LongestStreak(totalNumberDays); 
             * } 
             * 
             * void LongestStreak(int totalNumberDays) { 
             * int max = 0; 
             * int count = 1; 
             * startIndex = 0; 
             * endIndex = 0; 
             * for (int i = 0; i < totalNumberDays - 2; i++) { 
             * startIndex = i; 
             * while (i < totalNumberDays - 1 && Check(i)) { i++; count++; } 
             * if (max < count) { 
             * max = count; 
             * start = startIndex; 
             * endIndex = i; count = 1; 
             * } 
             * } 
             * } 
             * 
             * bool Check(int index) { 
             * for (int i = startIndex; i <= index; i++) { 
             * int temp = API.GetTemperatureOnDay(i); 
             * for (int j = i + 1; j <= index; j++) { 
             * int nexTemp = API.GetTemperatureOnDay(j ); 
             * if (Math.Abs(temp - nexTemp) > 5) 
             * return false; 
             * } 
             * } 
             * return true; 
             * } 
             * 
             * /** * Return the start day for the longest sequence of days where the mean temperature * is within five degrees.
             * public int GetStartDay()
             * { 
             * // Write your code here 
             * return start; 
             * } 
             * 
             * /** * Return the end day for the longest sequence of days where the mean temperature is * within five degrees. Note that the start and end day of the sequence may be the * same.
             * public int GetEndDay() { 
             * // Write your code here return 
             * endIndex; 
             * }
             * */
            }
    }
}
