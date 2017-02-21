using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LongestValidParenthesis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(longestValidParentheses("(()()"));
            Console.ReadKey();
        }

        public static int longestValidParentheses(string s)
        {
            if (s.Length == 0 || s.Length == 1) return 0;
            Stack<char> stack = new Stack<char>();
            int result = 0;
            int length = 0;

            for (int i = 0; i <= s.Length - 1; i++)
            {
                char c = s.ElementAt(i);
                if (stack.Count == 0 && c == ')')
                {
                    length = 0;
                    continue;
                }
                if (c == '(')
                {
                    stack.Push(c);
                }
                else
                {
                    stack.Pop();
                    length += 2;
                    result = Math.Max(length, result);
                }
            }

            return result;
        }
        //public static int longestValidParentheses(string s)
        //{
        //    Stack<int[]> stack = new Stack<int[]>();
        //    int result = 0;

        //    for (int i = 0; i <= s.Length - 1; i++)
        //    {
        //        char c = s.ElementAt(i);
        //        if (c == '(')
        //        {
        //            int[] a = { i, 0 };
        //            stack.Push(a);
        //        }
        //        else
        //        {
        //            if (stack.Count == 0 || stack.Peek()[1] == 1)
        //            {
        //                int[] a = { i, 1 };
        //                stack.Push(a);
        //            }
        //            else
        //            {
        //                stack.Pop();
        //                int currentLen = 0;
        //                if (stack.Count == 0)
        //                {
        //                    currentLen = i + 1;
        //                }
        //                else
        //                {
        //                    currentLen = i - stack.Peek()[0];
        //                }
        //                result = Math.Max(result, currentLen);
        //            }
        //        }
        //    }

        //    return result;
        //}
    }
}
