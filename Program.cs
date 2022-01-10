using System;
using System.Collections.Generic;
using System.IO;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int decisioncin, decisionsort;
            List<int> arr = new List<int>();
            Console.WriteLine("Выберите способ ввода: \n 1. Ввод из консоли \n 2. Ввод из файла \n 3. Автоматическая генерация");
            decisioncin = Convert.ToInt32(Console.ReadLine());
            switch (decisioncin)
            {
                case 1:
                    InterfaceForCinCons cincin = new InterfaceForCinCons();
                    cincin.cinm(ref arr); 
                    break;
                case 2:
                    InterfaceForCinFile cinfile = new InterfaceForCinFile();
                    cinfile.cinm(ref arr);
                    break;
                case 3:
                    InterfaceForCinRand randfile = new InterfaceForCinRand();
                    randfile.cinm(ref arr);
                    break;
                default:
                    InterfaceForCinRand randfiledef = new InterfaceForCinRand();
                    randfiledef.cinm(ref arr);
                    break;

            }
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Выберите метод сортировки: \n 1. Сортировка пузырьком \n 2. Сортировка вставками \n 3. Сортировка Шелла");
            decisionsort = Convert.ToInt32(Console.ReadLine());
            switch (decisionsort)
            {
                case 1:
                    Bubble newbsort = new Bubble();
                    newbsort.sortm(ref arr);
                    break;
                case 2:
                    Insertion newisort = new Insertion();
                    newisort.sortm(ref arr);
                    break;
                case 3:
                    Shell newssort = new Shell();
                    newssort.sortm(ref arr);
                    break;
                default:
                   
                    break;
            }
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

       
    }

   

  
}
