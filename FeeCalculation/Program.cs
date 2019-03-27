using FeeCalculation.MockData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TollFeeCalculator;

/// <summary>
/// En project base on Evry code test
/// </summary>
namespace FeeCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            var tollCalc = new TollCalculator();
            var fee = tollCalc.GetTollFee(new Car(), MockTimes.GetTimes());


            Console.WriteLine($"Fee: {fee}");
            Console.ReadKey();
        }
    }
}
