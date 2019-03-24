using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyAndSellGuld
{
    class Program
    {
        static void Main(string[] args)
        {
            Market market = new Market();
            Console.WriteLine("{0} - {1}",market.GetBuyDay(), market.GetSellDay());
            Console.ReadKey();

        }

        
    }
}
