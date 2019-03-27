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
            var fee = tollCalc.GetTollFee(new Car(), new DateTime[] { DateTime.Now, DateTime.Now.AddMinutes(70) });//Addlist off time for each car

            //Use Event or thread to trig time object for one car, and pass them to Calculation

            Console.WriteLine($"Fee: {fee}");
            Console.ReadKey();
        }
    }
}
