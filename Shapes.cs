using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace shapes
{
    class Area
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("type 1 to calculate area of square and type 2 to calculate area of rectangle");
            int i= Convert.ToInt32(System.Console.ReadLine());
            if (i==1)
            {
                System.Console.WriteLine("enter the length of side");
                int s= Convert.ToInt32(System.Console.ReadLine());
                
                int Ans =shapes.square.calc(s);
                System.Console.WriteLine("Area of square is : " + Ans );
            }
            else
            {
                System.Console.WriteLine("enter the length");
                int a= Convert.ToInt32(System.Console.ReadLine());

                System.Console.WriteLine("enter the breadth");
                int b= Convert.ToInt32(System.Console.ReadLine());

                int Ans=shapes.rectangle.calc(a,b);
                System.Console.WriteLine("Area of rectangle is : " + Ans );
            }
        }
    }
    class square
    {
        public static int calc(int a)
        {
            int Result=a*a;
            return Result;
        }
    }
    class rectangle
    {
        public static int calc(int a,int b)
        {
            int Result=a*b;
            return Result;
        }
    }

}