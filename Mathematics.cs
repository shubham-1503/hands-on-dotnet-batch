using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace math
{
    class operations
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("enter the first number");
            int a=Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("enter the second number");
            int b = Convert.ToInt32(System.Console.ReadLine());

            // System.Console.WriteLine("Addition of the 2 numbers is " + (a+b));
            // System.Console.WriteLine("Subtraction of the 2 numbers is " + (a-b));
            // System.Console.WriteLine("Multiplication of the 2 numbers is " + (a*b));  

            // Add(a, b);
            // Sub(a,b);
            // Mul(a,b);
            // Div(a,b);
            System.Console.WriteLine("Addition of the 2 numbers is "+ Addition.add(a,b));
            System.Console.WriteLine("Subtration of the 2 numbers is "+ Subtraction.sub(a,b));
            System.Console.WriteLine("Multiplication of the 2 numbers is "+ Multiplication.mul(a,b));
            System.Console.WriteLine("Division of the 2 numbers is "+ Division.div(a,b));
            

        }

        public class Addition
        {
            public static int add(int a, int b)
            {
                return a+b ;
            }
        }

        public class Subtraction
        {
            public static int sub(int a, int b)
            {
                return a-b ;
            }
        }

        public class Multiplication
        {
            public static int mul(int a, int b)
            {
                return a*b ;
            }
        }

        public class Division
        {
            public static int div (int a, int b)
            {
                return a/b ;
            }
        }





        static void  Add (int first,int second)
        {
            int result1 = first + second;
            System.Console.WriteLine("Addition of 2 numbers is : "+result1);
        }
        static void Sub (int first,int second)
        {
            int result2 = first - second;
            System.Console.WriteLine("Subtraction of 2 numbers is : "+result2);
        }
        
        static void Mul (int first,int second)
        {
            int result3 = first*second;
            System.Console.WriteLine("Multiplication of 2 numbers is : "+result3);
        }

        static void Div (int first,int second)
        {
            int result4 = first/second;
            System.Console.WriteLine("Division of 2 numbers is : "+result4);
        }
    }
}