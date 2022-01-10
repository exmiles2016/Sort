using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class InterfaceForCinRand : InterfaceForCin
    {
        public void cinm(ref List<int> arr)
        {
            Random rnd = new Random();
            int n = rnd.Next();
            for (int i = 0; i < n; i++)
            {
                arr.Add(Convert.ToInt32(Console.ReadLine()));
            }
        }
    }
}
