using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class Insertion : Sort_method
    {
        public void sortm(ref List<int> arr)
        {
            for (var i = 1; i < arr.Count; i++)
            {
                var key = arr[i];
                var j = i;
                while ((j > 1) && (arr[j - 1] > key))
                {
                    ForSwap.Swap(arr, j - 1, j);
                    j--;
                }

                arr[j] = key;
            }
            
        }
    }
}
