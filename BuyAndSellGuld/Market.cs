using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyAndSellGuld
{
    public class Market
    {
        private int dayForBuy,dayForSell;
        List<int> prices = new List<int>();

        public Market()
        {
            int theBuyDay = 2;
            CalculateSellAndBuyDay(API.ApiInstanse.GetNumberOfDays(), theBuyDay);
        }

        public int GetBuyDay()
        {
            return dayForBuy;
        }

        public int GetSellDay()
        {
            return dayForSell;
        }

        //Get the Max Price for Sell
        //Get the Lower Price for Buy
        private void CalculateSellAndBuyDay(int nrOfDays,int dayToCheck)
        {
            while (API.ApiInstanse.CheckInDaysList(dayToCheck) && dayToCheck < nrOfDays)
            {
                dayForBuy = dayToCheck;
                if (CheckSellDay(dayToCheck))
                {
                    dayForSell = dayToCheck + 1;
                    break;
                }
                else
                {
                    dayForSell = dayForBuy;
                }
                dayToCheck++;
            }

        }
        private bool CheckSellDay(int day)
        {
            int sellDay = day + 1;
            int buyDay = day;
            return API.ApiInstanse.GetPrisePerDay(sellDay) >= API.ApiInstanse.GetPrisePerDay(buyDay);
        }
    }
}
