using System;
class new1
{
    static public void Main()
    {
        byte[] B ={2,4,6,8,10};
        Console.WriteLine("BArray is :{0}",BitConverter.ToString(B));

        Console.WriteLine();
        String str = Convert.ToBase64String(B);
        Console.WriteLine("Base 64 String is :{0}", str);
    }
}