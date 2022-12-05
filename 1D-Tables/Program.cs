using System;


namespace _1D_Tables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a;
            int[] b;

            a = new int[] { 1, 2, 2, 3, 4 };
            b = new int[] {0, 1, 1, 2, 3, 3, 3};            
            var size = a.Length;
            for (int i = 0; i < size; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    if (a[i] == a[j])
                    {
                        for (int k = j; k < size - 1; k++)
                        {
                            a[k] = a[k + 1];
                        }
                        j--;
                        size--;
                    }
                }
            }
            var distincta = a.AsSpan().Slice(0, size);

            var test = false;
           foreach (int i in distincta)
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