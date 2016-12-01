using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {

        /*static bool binarySearch(int[] A, int v, int first, int last) //Classic binary search
        {
            if (last < first)
                return false;
            int i = first + (last - first) / 2;
            if (A[i] == v)
                return true;
            if (A[i] > v)
                return binarySearch(A, v, first, i-1);
            else
                return binarySearch(A, v, i+1, last);
        }*/


        /*Pseudo code
         * binarySearch(A, a, b, first, last)
         *      if(last<first)
         *          return FALSE
         *      i = first + (last - first) / 2
         *      if(A[i] >= a && A[i] <=b)
         *          return TRUE
         *      if(a[i] < a)
         *          return binarySearch(A, a, b, i+1, last)
         *      else
         *          return binarySearch(A, a, b, first, i-1)
         * */

        //Binary search of a value in tab A between values a and b.
        static bool binarySearch(int[] A, int a ,int b, int first, int last)
        {
            if (last < first)
                return false;
            int i = first + (last - first) / 2;
            if (A[i] >= a && A[i]<=b)
                return true;
            if (A[i] < a)
                return binarySearch(A, a, b, i + 1, last);
            else
                return binarySearch(A, a, b, first, i - 1);

        }
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 8, 10, 15, 21 };
            Console.WriteLine(binarySearch(array, 2, 5, 0, array.Length - 1));
            Console.ReadLine();
        }
    }
}
