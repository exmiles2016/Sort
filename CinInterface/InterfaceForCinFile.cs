using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Sort
{
    class InterfaceForCinFile : InterfaceForCin
    {
        public void cinm(ref List<int> arr)
        {
            string input;
            int check;
            input = Console.ReadLine();
            try
            {

                StreamReader sr = new StreamReader(input);
                arr.Add(Convert.ToInt32(sr.ReadLine()));
                check = arr[0];
                for (int i = 0; i < check; i++)
                {
                    arr.Add(Convert.ToInt32(sr.ReadLine()));
                }
                sr.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}
