using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestSequence
{
    public static class ApiClass
    {
        
        public static int GetTemperatureOnDay(int day)
        {
            Dictionary<int, int> tempList = new Dictionary<int, int>();
            tempList.Add(0,7);
            tempList.Add(1, 12);
            tempList.Add(2, 5);
            tempList.Add(3,3);
            tempList.Add(4,11);
            tempList.Add(5,6);
            tempList.Add(6,10);
            tempList.Add(7,2);
            tempList.Add(8,9);

            int value = 0;
            tempList.TryGetValue(day,out value);
            return value;

        }

        public static int GetNumDays()
        {
            return 8;
        }
    }
}
