using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringSwap
{
    class Driver
    {
         public static void print( ref string a, ref string b)
        {
            a = "Pawar";
            b = "Shubham";
        }

        public static void Main(string[] args)
        {
            string a= "Shubham";
            string b= "Pawar";
            System.Console.WriteLine(a+b);
            print( ref a, ref b);
            System.Console.WriteLine(a+b);


        }
        
       

    }
}