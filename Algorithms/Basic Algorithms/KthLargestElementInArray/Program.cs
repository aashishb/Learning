using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KthLargestElementInArray
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = {3, 2, 1, 5, 6, 4};

            Console.WriteLine(KthLargestElement(3, arr));
            Console.ReadKey();
        }

        public static int KthLargestElement(int k, int[] array)
        {
            List<int> list = new List<int>();
            list = array.ToList();
            list.Sort();

            return list[list.Count-k];
        }
    }
}
