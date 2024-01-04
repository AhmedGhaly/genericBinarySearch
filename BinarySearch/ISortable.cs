using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    internal interface ISortable <T>
    {
        int check(int indexElement, T searchedElement);

        // returned value
        // 0 if the value of the index given == search element
        // 1 if the value of the index given < search element
        // -1 if the value of the index given > search element
    }
}
