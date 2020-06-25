using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSortedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 1, 3,4, 31 };
            int[] b = new int[] { 4, 6, 30 };
            int[] c = Demo.MergeSortedArrays(a, b);
            foreach(int item in c)
            {
                Console.WriteLine(item + " " );
            }
            //Console.WriteLine(c);
            Console.ReadKey();
        }
    }

    static class Demo
    {
        public static int[] MergeSortedArrays(int[] arrSorted1, int[] arrSorted2)
        {
            int[] arrResultSorted = new int[arrSorted1.Length + arrSorted2.Length];
            int i = 0, j = 0, k = 0;
           
            while (i < arrSorted1.Length  && j < arrSorted2.Length)
            {
                if (arrSorted1[i] < arrSorted2[j])
                {
                    arrResultSorted[k] = arrSorted1[i];
                    i++;
                    k++;
                    
                }
                else
                {
                    arrResultSorted[k] = arrSorted2[j];
                    j++;
                    k++;
                    
                }

                
            }
            while (i < arrSorted1.Length)
            {
                arrResultSorted[k++] = arrSorted1[i++];
            }

            while (j < arrSorted2.Length)
            {
                arrResultSorted[k++] = arrSorted2[j++];
            }

            return arrResultSorted;
        }
    }
}
