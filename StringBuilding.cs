using System;
using System.Text;

namespace StringBuilding
{
    class append
    {
        public static void Main(string[] args)
        {
            StringBuilder addWord = new StringBuilder ("Shubham ");
            addWord.Append("Bhushan ");
            addWord.Append("Pawar");
            Console.WriteLine(addWord);
        }
    }
}