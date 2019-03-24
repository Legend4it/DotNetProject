using System;
using System.Collections.Generic;
using System.Linq;

namespace BuyAndSellGuld
{

    /// <summary>
    /// Single Ton Patter Implementation
    /// </summary>
    public sealed class API
    {
        private Dictionary<int,int> days;

        private static API instance = null;

        private API()
        {
            days = new Dictionary<int, int> {
                { 2,4},
                { 3,10},
                { 4,5},
                { 5,9},
                { 6,2},
                { 7,15},
            };
        }

        public static API ApiInstanse {
            get {
                if (instance == null)
                {
                    instance = new API();
                };
                return instance;
            }
        }

        public int GetNumberOfDays() => days.Count();
        public int GetPrisePerDay(int day) => days.FirstOrDefault(d=>d.Key==day).Value;
        public bool CheckInDaysList(int day)
        {
            return days.ContainsKey(day);
        }
    }
}
