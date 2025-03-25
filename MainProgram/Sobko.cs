using System;

namespace sobko
{
    public class Task11
    {
        public static int[] Run(int[] arr)
        {
            if (arr.Length == 0)
            {
                Console.WriteLine("Масив порожній, операція неможлива.");
                return arr;
            }
            return InsertMinMax(arr);
        }

        private static int[] InsertMinMax(int[] arr)
        {
            int min = arr[0];
            int max = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min) min = arr[i];
                if (arr[i] > max) max = arr[i];
            }

            int[] newArr = new int[arr.Length + 2];
            newArr[0] = min;
            newArr[newArr.Length - 1] = max;

            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i + 1] = arr[i];
            }

            return newArr;
        }
    }
}
