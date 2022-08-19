using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Datastructures
{
    class DemoArray
    {
        public static void arr()
        {
            int[] arr = new int[10] {0,1,2,3,4,5,6,7,8,9};
            int max = arr[0];
            for(int i=1; i<10; i++)
            {
                if(arr[i]> max)
                {
                    max= arr[i];
                }
            }
            System.Console.WriteLine("largest number is : " + max);
        }

    }

    class DemoArrayList
    {
        public static void arrlist()
        {
            ArrayList al = new ArrayList();         

            al.Add(0);
            al.Add(1);
            al.Add(2);
            al.Add(3);
            al.Add(4);
            al.Add(5);
            al.Add(6);
            al.Add(7);
            al.Add(8);
            al.Add(10);

            int biggest = Convert.ToInt32(al[0]);
            for(int i=1; i<10; i++)
            {
                if(Convert.ToInt32(al[i])> biggest)
                {
                    biggest =(int) al[i];
                }
            }
            System.Console.WriteLine("largest number in array list is : " + biggest);

        }
    }

    class DemoLinkedList
    {
        public static void linkedlist()
        {
            LinkedList<int> ll = new LinkedList<int>();

            ll.AddLast(0);
            ll.AddLast(1);
            ll.AddLast(2);
            ll.AddLast(3);
            ll.AddLast(4);
            ll.AddLast(5);
            ll.AddLast(6);
            ll.AddLast(7);
            ll.AddLast(8);
            ll.AddLast(11);

            System.Console.WriteLine("the largest number in linked list is: "+ ll.Max());
        }
    }

    class Driver
    {
        public static void Main(string[] args)
        {
            Datastructures.DemoArray.arr();
            Datastructures.DemoArrayList.arrlist();
            Datastructures.DemoLinkedList.linkedlist();

        }
    }
}