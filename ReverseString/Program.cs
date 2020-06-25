using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Today is a great day!";
            string s = Demo.ReverseString(name);
            Console.WriteLine(s);
            string c = Demo.ReverseChar(name);
            Console.WriteLine(c);
            Console.ReadLine();
        }
    }

    public static class Demo
    {
        //STRING WAY = O(n)
        public static string ReverseString(string strRev)
        {
            //char[] strOriginalArray = strRev.ToCharArray();
            string[] strOriginalArray = strRev.ToCharArray().Select(c => c.ToString()).ToArray();
            string[] strRevArray = new string[strOriginalArray.Length];
            string returnReverse = string.Empty;
            int count = 0;
            for (int i = strOriginalArray.Length-1; i >= 0; i--)
            {
                
                strRevArray[count] = strOriginalArray[i];
                count++;
               


            }
            returnReverse =  string.Join("", strRevArray);
            return returnReverse;
        }

        //CHAR WAY
        public static string ReverseChar(string strRev)
        {
           // char[] strOriginalArray = strRev.ToCharArray();
            char[] strRevArray = new char[strRev.Length];
            string returnReverse = string.Empty;
            int count = 0;
            for (int i = strRev.Length - 1; i >= 0; i--)
            {

                strRevArray[count] = strRev[i];
                count++;
               // returnReverse = strRevArray.ToString();


            }
            //returnReverse = string.Join("", strRevArray);
            return new string(strRevArray);
        }
    }
}
