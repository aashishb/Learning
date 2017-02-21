using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WordLadder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string start = "hit";
            string end = "cog";
            List<string> dict = new List<string>();

            dict.Add("hot");
            dict.Add("dot");
            dict.Add("dog");
            dict.Add("lot");
            dict.Add("log");

            Solution sol = new Solution();

            Console.WriteLine(sol.ladderLength(start, end, dict));

            Console.ReadKey();
        }
    }

    public class WordNode
    {
        public string word;
        public int numSteps;

        public WordNode(string word, int numSteps)
        {
            this.word = word;
            this.numSteps = numSteps;
        }
    }

    public class Solution
    {
        public int ladderLength(string beginWord, string endWord, List<string> wordDict)
        {
            List<WordNode> queue = new List<WordNode>();
            queue.Add(new WordNode(beginWord, 1));

            wordDict.Add(endWord);

            while (queue.Count != 0)
            {
                WordNode top = queue.First();
                string word = top.word;

                if (word.Equals(endWord))
                {
                    return top.numSteps;
                }

                char[] arr = word.ToCharArray();
                for (int i = 0; i < arr.Count(); i++)
                {
                    for (char c = 'a'; c <= 'z'; c++)
                    {
                        char temp = arr[i];
                        if (arr[i] != c)
                        {
                            arr[i] = c;
                        }

                        String newWord = new String(arr);
                        if (wordDict.Contains(newWord))
                        {
                            queue.Add(new WordNode(newWord, top.numSteps + 1));
                            wordDict.Remove(newWord);
                        }

                        arr[i] = temp;
                    }
                }
            }

            return 0;
        }
    }
}
