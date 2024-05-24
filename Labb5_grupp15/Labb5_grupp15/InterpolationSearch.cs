using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5_grupp15
{
    public class InterpolationSearch
    {
        public static int Search(int[] array, int key)
        {
            int low = 0;
            int high = array.Length - 1;

            while (low <= high && key >= array[low] && key <= array[high])
            {
                if (low == high)
                {
                    if (array[low] == key) return low;
                    return -1;
                }

                int pos = low + ((key - array[low]) * (high - low) / (array[high] - array[low]));

                if (array[pos] == key)
                {
                    return pos;
                }

                if (array[pos] < key)
                {
                    low = pos + 1;
                }
                else
                {
                    high = pos - 1;
                }
            }
            return -1; // Nyckeln hittades inte
        }
    }

}