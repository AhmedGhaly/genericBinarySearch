using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    internal class SortIntgers : ISortable<int>
    {
        int[] arr;
        public SortIntgers(int[] arr)
        {
            this.arr = arr;
        }
        public int check(int indexElement, int searchedElement)
        {
            if (arr[indexElement] > searchedElement)
                return -1;
            else if (arr[indexElement] < searchedElement)
                return 1;
            else return 0;
        }
    }
}
