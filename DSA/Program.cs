using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello World");
            int[] arrNum = new int[] { 6, 4,3, 1, 2 };
            bool value= Demo.SumPair(arrNum, 9);
            Console.WriteLine(value);
            Console.ReadKey();
        }
    }
    public static class Demo
    {
        public static bool SumPair(int[] arraynum, int sum)
        {
            HashSet<int> myhash1 = new HashSet<int>();
            for (int i = 0; i < arraynum.Length; i++)
            {
                if (myhash1.Contains(arraynum[i]))
                {
                    return true;
                }
                myhash1.Add(sum - arraynum[i]);         //Find and add the complement pair of a given number that is equal to the given sum.
            }
            return false;
        }
    }
}
