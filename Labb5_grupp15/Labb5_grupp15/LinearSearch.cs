using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5_grupp15
{
    public class LinearSearch
    {
        
        public static int Search(int[] array, int key)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == key)
                {
                    return i;
                }
            }
            return -1; // Nyckeln hittades inte
        }
    }
}
