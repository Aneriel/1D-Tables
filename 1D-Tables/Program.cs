using System;
using System.Text;

namespace _1D_Tables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a;
            int[] b;
            a = new int[] { 0, 1, 1, 2, 3, 3, 3 };
            b = new int[] { 0, 1, 2, 3, 3 };
            int[] all = new int[400];
             var sizea = a.Length;
             for (int i = 0; i < sizea; i++)
             {
                 for (int j = i + 1; j < sizea; j++)
                 {
                     if (a[i] == a[j])
                     {
                         for (int k = j; k < sizea - 1; k++)
                         {
                             a[k] = a[k + 1];
                         }
                         j--;
                         sizea--;
                     }
                 }
             }
             var sizeb = b.Length;
             for (int i = 0; i < sizeb; i++)
             {
                 for (int j = i + 1; j < sizeb; j++)
                 {
                     if (b[i] == b[j])
                     {
                         for (int k = j; k < sizeb - 1; k++)
                         {
                             b[k] = b[k + 1];
                         }
                         j--;
                         sizeb--;
                     }
                 }
             }
             var distincta = a.AsSpan().Slice(0, sizea);
             var distinctb = b.AsSpan().Slice(0, sizeb);
             var test = false;
            int positionInArray = 0;
             foreach (int i in distincta)
             {
                 if (Array.IndexOf(b, i) < 0)
                 {
                    all[positionInArray] = i;
                    test = true;
                    positionInArray++;
                }


             }
             foreach (int i in distinctb)
             {
                 if (Array.IndexOf(a, i) < 0)
                {

                    all[positionInArray] = i;
                    test = true;
                    positionInArray++;
                 }
             }

            
            Array.Resize(ref all, positionInArray++);
             Array.Sort(all);
             foreach (int z in all)
             {
                 Console.Write($"{z} ");

             }


             if (test == false)
             {
                 Console.WriteLine("empty");
             }

        }

    }
}