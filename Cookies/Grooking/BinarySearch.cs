using System;
namespace Cookies.Grooking
{
    public static class BinarySearch
    {
        public static int BinarySearcher(int[] list,int item)
        {
            int low = 0;
            int high = list.Length - 1;

            while (low <= high)
            {
                int middle = (low + high) / 2;
                if (item == list[middle]) {
                    return middle;
                }
                else if(item<list[middle]){
                    high = middle - 1;
                }
                else
                {
                    low = middle + 1;
                }
            }
            return 0;
        }
    }
}
