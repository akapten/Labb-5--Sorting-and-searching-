using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5_grupp15
{
    public class BinarySearch
    {
       
       
            public static int Search(int[] array, int key)
            {
                int low = 0;
                int high = array.Length - 1;

                while (low <= high)
                {
                    int mid = (low + high) / 2;
                    if (array[mid] == key)
                    {
                        return mid;
                    }
                    else if (array[mid] < key)
                    {
                        low = mid + 1;
                    }
                    else
                    {
                        high = mid - 1;
                    }
                }

                return -1; // Nyckeln hittades inte
            }
        
    }
}
