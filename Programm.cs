using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Principal;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace amfastestfakboy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] o = { 22,21,20,19,18,17,16,15,14,13,12,11,10,9,8,7,6,5,4,3,2,1 };
            print(sort(o));
        }
        static int[] sort(int[] a)
        {
            if (a.Length <=1) return a;
            
            int center = a.Length / 2;
            int i = 0;
            int j = a.Length - 1;
            while (i <= j)
            {
                while (a[i] < a[center]) i++;
                while (a[j] >= a[center+1]) j--;
                if (i<= j)
                {
                    int tmp = a[i];
                    a[i] = a[j];
                    a[j] = tmp;
                    i++;
                    j--;
                }
            }
            int[] firstHalf = sort(a.Take(center).ToArray());
            int[] secondHalf = sort(a.Skip(center).ToArray());
            a = firstHalf.Concat(secondHalf).ToArray();
            return a;
        }
        ///<summary>вывод массива</summary><returns>массив вывод</returns>
        static void print(int[] a)
        {
            for (int i = 0; i < a.Length; i++) Console.Write($"{a[i]} ");
            Console.WriteLine();

        }
    }
}
