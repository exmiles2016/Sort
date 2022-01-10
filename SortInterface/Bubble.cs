using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    public class Bubble : Sort_method
    {
        public void sortm(ref List<int> arr)
        {
            var len = arr.Count;
            for (var i = 1; i < len; i++)
            {
                for (var j = 0; j < len - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        ForSwap.Swap(arr, j, j+1);
                    }
                }
            }

           
        }
    }
}
