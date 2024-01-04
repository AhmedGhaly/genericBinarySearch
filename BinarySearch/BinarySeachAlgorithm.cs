using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    internal class BinarySeachAlgorithm <T>
    {
        public ISortable<T> sortable { get; set; }

        public BinarySeachAlgorithm(ISortable<T> sortable)
        {
            this.sortable = sortable;
        }
        public int binarySearch(T item, int length)
        {
            int low = 0;
            int high = length;
            int res = 0;
            while (low <= high)
            {
                int middle = (low + high + 1) / 2;
                if (sortable.check(middle, item) == 1)
                    low = middle + 1;
                else if (sortable.check(middle, item) == -1)
                    high = middle - 1;
                else if (sortable.check(middle, item) == 0)
                {
                    res = middle;
                    break;
                }
            }
            return res;
        }
    }
}
