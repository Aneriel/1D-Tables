using System;
namespace _1D_Tables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a;
            int[] b;
           // int counter = 0;
            a = new int[] { 0, 1, 1, 2, 3, 3, 3 };
            b = new int[] { 0, 2, 2, 3, 4 };
            //int[] distinctArr = a;

            var test = false;
            /*foreach (int distinctVal in a)
            {
                if(Array.IndexOf(distinctArr, distinctVal) == 0)
                {
                    Console.Write($"{distinctVal} ");
                }
            }*/
           foreach (int i in a)
            {

                if (Array.IndexOf(b, i) < 0)
                {
                    Console.Write($"{i} ");
                    test = true;
                }


            }
            if (test == false)
            {
                Console.WriteLine("empty");
            }

        }
    }
}