using System;
using System.IO.Pipelines;
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

          
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(input[i]);
                
            }

            OneBeforeEven(ref arr);
            Console.WriteLine();
            Console.WriteLine("Ваш остаточний масив має вигляд: ");
            Output(arr);

        }

        private static int[] OneBeforeEven(ref int[] arr)
        {
            int n = arr.Length;
            int cnt = 0;
            for(int i = 0; i < n; i++)
            {
                if (arr[i] % 2 ==0)
                {
                    cnt++;
                }
            }

            Array.Resize(ref arr, n + cnt);

            for(int i = n - 1; i >= 0; i--)
            {
                if (arr[i] % 2 == 0)
                {
                    for(int j = arr.Length - 1; j > i +1; j--)
                    {
                        arr[j] = arr[j - 1];
                    }

                    arr[i + 1] = arr[i];
                    arr[i] = 1;
                }
            }


            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] % 2 != 0 )
            //    {
            //        arrPlusOne[index++] = arr[i];
            //    }
            //    if (arr[i] % 2 == 0)
            //    {
            //        arrPlusOne[index++] = 1;
            //        arrPlusOne[index++] = arr[i];
            //    }
            //}
            return arr;

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
