using System;

//16. Вставити перед кожним парним елементом елемент із значенням 1

namespace shulzhenko
{
    public class Task16
    {
        public static int[] Run(int[] arr)
        {
            //Console.WriteLine("Введіть довшину масиву: ");
            //int n = int.Parse(Console.ReadLine());

            //Console.WriteLine("Введіть значення масиву (через пробіл): ");
            //string[] input = Console.ReadLine().Split();
            //int[] arr = new int[n];

          
            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = int.Parse(input[i]);
                
            //}

            OneBeforeEven(ref arr);

            
            //Console.WriteLine();
            //Console.WriteLine("Ваш остаточний масив має вигляд: ");
            //Output(arr);
            return arr;
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

            return arr;

        }

        //private static void Output(int[] arr)
        //{
        //    foreach (int i in arr)
        //    {
        //        Console.Write(i + " ");
        //    }
        //}
    }
}
