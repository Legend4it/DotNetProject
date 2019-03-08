using System;
using Hackerrank;

namespace LongestSequenceNewImplementation
{
    class Program
    {
        private static int totalNumberDays = 0;
        private static int startIndex;
        private static int endIndex;
        private static int start;

        static void Main(string[] args)
        {
            InitSequence();
            Console.WriteLine("Result: {0} {1}", GetStartDay(), GetEndDay());

            Console.ReadKey();


        }


        public static void InitSequence()
        {
            totalNumberDays = ApiClass.GetNumDays();
            LongestStreak(totalNumberDays);
        }

        public static void LongestStreak(int totalNumberDays)
        {
            int max = 0;
            int count = 1;
            startIndex = 0;
            endIndex = 0;
            for (int i = 0; i < totalNumberDays - 2; i++)
            {
                startIndex = i;
                while (i < totalNumberDays - 1 && Check(i)) { i++; count++; }
                if (max < count)
                {
                    max = count;
                    start = startIndex;
                    endIndex = i; count = 1;
                    }
                }
        }

        public static bool Check(int index)
        {
            for (int i = startIndex; i <= index; i++)
            {
                int temp = ApiClass.GetTemperatureOnDay(i);
                for (int j = i + 1; j <= index; j++)
                {
                    int nexTemp = ApiClass.GetTemperatureOnDay(j);
                        if (Math.Abs(temp - nexTemp) > 5)
                            return false;
                }
            }
            return true;
        }

        public static int GetStartDay()
        {
            return start;
        }

        public static int GetEndDay()
        {
            return endIndex;
        }
    }
}
