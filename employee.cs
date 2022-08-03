using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employees
{
    class Driver
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("enter the number of employees");
            int n=Convert.ToInt32(System.Console.ReadLine());

            for(int i=1;i<=n;i++)
            {
                System.Console.WriteLine("enter the name of the employee");
                string employee_name=System.Console.ReadLine();

                System.Console.WriteLine("enter the address of the employee");
                string employee_address=System.Console.ReadLine();

                Employees.details.print(employee_name,employee_address);
            }


            // string n1= "Shubham Pawar";
            // string a1 = "kandivali";

            // string n2 = "SurePrep" ;
            // string a2 = "andheri";

            // Employees.details.print(n1,a1);
            // Employees.details.print(n2,a2);


        }
    }
    class details
    {
        public static void print(string name, string address)
        {

            System.Console.WriteLine("Name of the employee is : " + name);
            System.Console.WriteLine("Address of the employee is : " + address);
        }
    }
}