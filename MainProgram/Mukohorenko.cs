using System;

namespace mukohorenko
{
    public class Task6
    {
        public static int[] Run(int[] arr)
        {
            RemoveEvenIndices(arr);
            return arr;
        }
        static int[] RemoveEvenIndices(int[] arr)
        {
            int newSize = arr.Length / 2;
            int[] newArr = new int[newSize];
            for (int i = 1, j = 0; i < arr.Length; i += 2)
            {
                newArr[j++] = arr[i];
            }
            return newArr;
        }
    }
}

