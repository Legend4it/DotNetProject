using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestSequence
{
    class TestClass<T>:List<T>
    {
        public IEnumerable<T> Where(Func<T,Boolean> predicate)
        {
            return Enumerable.Where(this, predicate);
        }
    }
}
