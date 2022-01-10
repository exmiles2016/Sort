using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Sort
{
    class Shell : Sort_method
    {
       public void sortm(ref List<int> arr)
        {
            var d = arr.Count / 2;
            while (d >= 1)
            {
                for (var i = d; i < arr.Count; i++)
                {
                    var j = i;
                    while ((j >= d) && (arr[j - d] > arr[j]))
                    {
                        ForSwap.Swap(arr, j, j - d);
                        j = j - d;
                    }
                }
                d = d / 2;
            }
          
        }
    }
}
