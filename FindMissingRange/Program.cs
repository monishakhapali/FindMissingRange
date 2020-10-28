using System;

namespace FindMissingRange
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int[] a = { 1, 2, 3, 50, 52, 75 };
            int i = 0;
            while (i < a.Length)
            {
                if(i== a.Length-1)
                {
                    Console.WriteLine("range is" + (a[i] + 1) + 99);
                    break;
                }
                if (a[i + 1] - a[i] != 1)
                {
                    Console.WriteLine("range is" + (a[i] + 1) + " " + (a[i + 1] - 1));
                }
                i++;
            }
            
            Console.ReadLine();
        }
    }
}
