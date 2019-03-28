using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acando
{
    class MovingTotal
    {
        private List<int> mainList=new List<int>();
        public void Append(int[] list)
        {
            if (list.Count() == 3)
            {
                mainList.AddRange(list);
            }
        }

            public bool Contains(int total)
            {
                var latsThreeElemt = Enumerable.Reverse(mainList).Take(3).Reverse().ToList();
                return latsThreeElemt.Sum() == total;
            }

        public static void Main(string[] args)
        {
            MovingTotal movingTotal = new MovingTotal();

            movingTotal.Append(new int[] { 1, 2, 3 });

            Console.WriteLine(movingTotal.Contains(6));
            Console.WriteLine(movingTotal.Contains(9));

            movingTotal.Append(new int[] { 4 });

            Console.WriteLine(movingTotal.Contains(9));
        }
    }
}
