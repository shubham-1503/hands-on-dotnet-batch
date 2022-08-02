using System;

namespace TimeStamp
{
    class date
    {
        public static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2022,8,2,16,40,15);
            DateTime d2 = new DateTime(2000,3,15,9,30,10);
            
            //TimeSpan interval = d1 - d2;
            //System.Console.WriteLine(interval);

            TimeStamp.timediff.calc(d1,d2);
        }
    }
    class timediff
    {
        public static void calc(DateTime Date1, DateTime Date2)
        {
            TimeSpan interval = Date1 - Date2;
            System.Console.WriteLine("Time difference is : "+ interval);
        }
    }
}
