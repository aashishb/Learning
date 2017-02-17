using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StringReversal
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string str = "adding to git";
            string strReverse = string.Empty;

            string[] strArray = str.Split();

            for (int i = strArray.Length-1; i >= 0; i--)
            {
                if (strReverse == "")
                {
                    strReverse = strArray[i];
                }
                else
                {
                    strReverse = strReverse + " " + strArray[i];
                }
            }

            Console.WriteLine(strReverse);
            Console.ReadKey();
        }
    }
}
