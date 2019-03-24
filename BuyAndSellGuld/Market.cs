using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyAndSellGuld
{
    public class Market
    {
        private int buyDay,sellDay;
        List<int> prices = new List<int>();

        public Market()
        {
            int nrOfDays = API.ApiInstanse.GetNumberOfDays();

            for (int i = 0; i < nrOfDays; i++)
            {
                if(API.ApiInstanse.CheckInDaysList(i))
                {
                    prices.Add(API.ApiInstanse.GetPrisePerDay(i));
                }
            }

            prices.Sort();

            //Get the Max Price for Sell
            buyDay = prices.First();

            //Get the Lower Price for Buy
            sellDay = prices.Last();
        }

        public int GetBuyDay()
        {
            return buyDay;
        }

        public int GetSellDay()
        {
            return sellDay;
        }
    }
}
