using System;
using System.Text;

namespace sentence
{
    class text
    {
        public static void Main(string[] args)
        {
            sentence.stringbuilders.append("Shubham ","Pawar");
            sentence.strings.concatenate("hp ","laptop");

        }
    }
    class strings
    {
        public static void concatenate(string word1, string word2)
        {
            string fullword = word1 +word2;
            System.Console.WriteLine(fullword);
        }
    }

    class stringbuilders
    {
        public static void append(string word1, string word2)
        {
            StringBuilder addWord = new StringBuilder (word1);
            addWord.Append(word2);
            Console.WriteLine(addWord);
        }
    }
}