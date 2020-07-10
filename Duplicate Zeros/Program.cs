using System;
using System.Buffers;
using System.Collections;

namespace Duplicate_Zeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new[] { 1, 0, 2, 3, 0, 4, 5, 0 };
            DuplicateZeros(arr);
            foreach (int i in arr) Console.WriteLine(i);
            Console.WriteLine("Hello World!");
        }

        public static void DuplicateZeros(int[] arr)
        {
            int length = arr.Length;
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == 0)
                {
                    i = i + 1;
                    if (i < length)
                    {
                        for(int j = length -1; j > i; j--)
                        {
                            arr[j] = arr[j - 1];
                        }
                        arr[i] = 0;
                    }
                }
            }
        }
    }
}
