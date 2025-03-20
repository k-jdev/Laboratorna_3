using System;
//16. Вставити перед кожним парним елементом елемент із значенням 1

namespace block_1_task_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть довшину масиву: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Введіть значення масиву (через пробіл): ");
            string[] input = Console.ReadLine().Split();
            int[] arr = new int[n];

            int cntEven = 0;
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(input[i]);
                if (arr[i] % 2 == 0) cntEven++;
            }

            int[] resArr = OneBeforeEven(arr, cntEven);
            Console.WriteLine();
            Console.WriteLine("Ваш остаточний масив має вигляд: ");
            Output(resArr);

        }

        private static int[] OneBeforeEven(int[] arr, int cnt)
        {
            int[] arrPlusOne = new int[arr.Length + cnt];
            int index = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0 )
                {
                    arrPlusOne[index++] = arr[i];
                }
                if (arr[i] % 2 == 0)
                {
                    arrPlusOne[index++] = 1;
                    arrPlusOne[index++] = arr[i];
                }
            }
            return arrPlusOne;

        }

        private static void Output(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
        }
    }
}
