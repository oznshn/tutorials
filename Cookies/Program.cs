using System;
using System.Collections.Generic;
using Cookies.Grooking;

namespace Cookies
{
    class MainClass
    {
        public static void Main(string[] args)
        {


            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int item = 2;
            var res = BinarySearch.BinarySearcher(arr, item);
            Console.WriteLine("result! {0}",res);



            var list =  new List<int> { 3, 5, 2, 1, 4, 7, 9, 6, 8 };

            var resSort = SelectionSort.SelectionSorter(list);
        }
    }
}
